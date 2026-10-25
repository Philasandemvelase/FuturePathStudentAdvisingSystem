using System;
using System.Collections.Generic;
using FuturePathStudentAdvisingSystem.Business.Entities;
using FuturePathStudentAdvisingSystem.Business.Models;
using FuturePathStudentAdvisingSystem.DAL;

namespace FuturePathStudentAdvisingSystem.Business.Controllers
{
    /// <summary>
    /// Use case (Administrator): Maintain the interest questionnaire, i.e. the questions,
    /// their categories, and how strongly each category counts for each programme
    /// (DegreeInterestMap.weightedScore, 0..1).
    /// </summary>
    public class QuestionnaireController
    {
        private InterestQuestionDAL questionDal = new InterestQuestionDAL();
        private InterestQuestionCategoryDAL categoryDal = new InterestQuestionCategoryDAL();
        private DegreeInterestMapDAL mapDal = new DegreeInterestMapDAL();

        /// <summary>All questions (questionID order, from the DAL) with their category names.</summary>
        public List<QuestionListItem> GetQuestions()
        {
            Dictionary<int, string> names = new LookupController().CategoryNames();
            List<QuestionListItem> items = new List<QuestionListItem>();
            foreach (InterestQuestion q in questionDal.GetAll())
            {
                QuestionListItem item = new QuestionListItem();
                item.Question = q;
                item.CategoryName = LookupController.NameOf(names, q.CategoryID);
                items.Add(item);
            }
            return items;
        }

        /// <summary>All categories sorted by name.</summary>
        public List<InterestQuestionCategory> GetCategories()
        {
            List<InterestQuestionCategory> categories = categoryDal.GetAll();
            categories.Sort(CompareCategories);
            return categories;
        }

        private static int CompareCategories(InterestQuestionCategory a, InterestQuestionCategory b)
        {
            return string.Compare(a.CategoryName, b.CategoryName, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>Adds (QuestionID = 0) or updates a question.</summary>
        public void SaveQuestion(InterestQuestion question)
        {
            if (question.QuestionText == null)
            {
                question.QuestionText = "";
            }
            question.QuestionText = question.QuestionText.Trim();

            if (question.QuestionText == "")
            {
                throw new BusinessRuleException("Question text is required.");
            }
            if (question.QuestionText.Length > 255)
            {
                throw new BusinessRuleException("Question text can be at most 255 characters.");
            }
            if (question.CategoryID <= 0)
            {
                throw new BusinessRuleException("Select an interest category.");
            }

            if (question.QuestionID == 0)
            {
                questionDal.Add(question);
            }
            else if (questionDal.Update(question) == false)
            {
                throw new BusinessRuleException("This question no longer exists.");
            }
        }

        /// <summary>Adds a new category and returns it.</summary>
        public InterestQuestionCategory AddCategory(string name)
        {
            if (name == null)
            {
                name = "";
            }
            name = name.Trim();

            if (name == "")
            {
                throw new BusinessRuleException("Enter a category name.");
            }
            if (name.Length > 50)
            {
                throw new BusinessRuleException("Category name can be at most 50 characters.");
            }
            foreach (InterestQuestionCategory other in categoryDal.GetAll())
            {
                if (other.CategoryName.ToLower() == name.ToLower())
                {
                    throw new BusinessRuleException("That category already exists.");
                }
            }

            InterestQuestionCategory category = new InterestQuestionCategory();
            category.CategoryName = name;
            categoryDal.Add(category);
            return category;
        }

        public void RenameCategory(int categoryID, string newName)
        {
            InterestQuestionCategory category = categoryDal.GetByID(categoryID);
            if (newName == null)
            {
                newName = "";
            }
            newName = newName.Trim();

            if (category == null || newName == "" || newName == category.CategoryName)
            {
                return;   // nothing to change
            }
            if (newName.Length > 50)
            {
                throw new BusinessRuleException("Category name can be at most 50 characters.");
            }
            foreach (InterestQuestionCategory other in categoryDal.GetAll())
            {
                if (other.CategoryID != categoryID && other.CategoryName.ToLower() == newName.ToLower())
                {
                    throw new BusinessRuleException("Another category already has that name.");
                }
            }

            category.CategoryName = newName;
            categoryDal.Update(category);
        }

        /// <summary>The strongest programme mapping of a category (null if none), to pre-fill the editor.</summary>
        public DegreeInterestMap GetTopMapping(int categoryID)
        {
            DegreeInterestMap best = null;
            foreach (DegreeInterestMap map in mapDal.GetAll())
            {
                if (map.CategoryID != categoryID)
                {
                    continue;
                }
                if (best == null || map.WeightedScore > best.WeightedScore)
                {
                    best = map;
                }
            }
            return best;
        }

        /// <summary>Creates or updates the weighting of a category for a programme.</summary>
        public void SaveMapping(int degreeID, int categoryID, decimal weight)
        {
            if (degreeID <= 0)
            {
                throw new BusinessRuleException("Select a programme for the mapping.");
            }
            if (categoryID <= 0)
            {
                throw new BusinessRuleException("Select a category for the mapping.");
            }
            if (weight < 0 || weight > 1)
            {
                throw new BusinessRuleException("The weighting must be between 0 and 1.");
            }

            // Is there already a mapping for this programme and category?
            DegreeInterestMap existing = null;
            foreach (DegreeInterestMap map in mapDal.GetByDegree(degreeID))
            {
                if (map.CategoryID == categoryID)
                {
                    existing = map;
                }
            }

            if (existing == null)
            {
                DegreeInterestMap newMap = new DegreeInterestMap();
                newMap.DegreeID = degreeID;
                newMap.CategoryID = categoryID;
                newMap.WeightedScore = weight;
                mapDal.Add(newMap);
            }
            else
            {
                existing.WeightedScore = weight;
                mapDal.Update(existing);
            }
        }
    }
}
