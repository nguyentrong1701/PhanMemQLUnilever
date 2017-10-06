using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unilever.DTO.Entity;

namespace Unilever.DAO
{
    class CategoryDAO
    {
        public List<Category> GetAll()
        {
            using (UnileverEntities entity = new UnileverEntities())
            {
                return entity.Categories.ToList();
            }
        }

        public bool IsExistedName(Category cat)
        {
            bool flag = true;

            using (UnileverEntities ent = new UnileverEntities())
            {
                var tempCat = ent.Categories.Where(i => i.Name == cat.Name).FirstOrDefault();
                
                if(tempCat == null)
                {
                    flag = false;
                }
                else
                {
                    
                }
            }

            return flag;
        }

        public bool Add(Category cat)
        {
            bool flag = true;

            if (IsExistedName(cat) == true)
            {
                flag = false;
            }
            else
            {
                try
                {
                    using (UnileverEntities entity = new UnileverEntities())
                    {
                        entity.Categories.Add(cat);
                        entity.SaveChanges();
                    }
                }
                catch (System.Exception ex)
                {
                    ex.Message.ToString();
                    flag = false;
                }
            }

            return flag;
        }

        public bool Remove(int id)
        {
            bool flag = true;

            using (UnileverEntities entity = new UnileverEntities())
            {
                var cat = entity.Categories.Where(c => c.Id == id).FirstOrDefault();
                if (cat != null)
                {
                    try
                    {
                        entity.Categories.Remove(cat);
                        entity.SaveChanges();
                    }
                    catch (System.Exception ex)
                    {
                        ex.Message.ToString();
                        return false;
                    }
                }
                else
                {
                    flag = false;
                }
            }

            return flag;
        }

        public bool Update(Category cat)
        {
            bool flag = true;

            if (IsExistedName(cat) == true)
            {
                flag = false;
            }
            else
            {
                using (UnileverEntities entity = new UnileverEntities())
                {
                    var catData = entity.Categories.Where(i => i.Id == cat.Id).FirstOrDefault();
                    if (catData != null)
                    {
                        catData.Name = cat.Name;
                        entity.SaveChanges();
                    }
                    else
                    {
                        flag = false;
                    }
                }
            }

            return flag;
        }
    }
}
