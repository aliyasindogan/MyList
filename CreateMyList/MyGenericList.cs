using System;
using System.Collections;
using System.Collections.Generic;

namespace CreateMyList
{
    public class MyEntityList<TEntity> : IEnumerable<TEntity>
    {
        private List<TEntity> list;

        public MyEntityList()
        {
            list = new List<TEntity>();
        }

        public void Add(TEntity entity)
        {
            list.Add(entity);
        }

        public IEnumerator<TEntity> GetEnumerator()
        {
            return new MyEntityIEnumerator(list);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public class MyEntityIEnumerator : IEnumerator<TEntity>
        {
            private List<TEntity> entities;
            private int index = -1;

            public MyEntityIEnumerator()
            {
            }

            public MyEntityIEnumerator(List<TEntity> list)
            {
                entities = list;
            }

            public bool MoveNext()
            {
                index++;
                return (index < entities.Count);
            }

            public TEntity Current
            {
                get
                {
                    return entities[index];
                }
            }

            public void Reset()
            {
                index = -1;
            }

            #region MyRegion

            object IEnumerator.Current => throw new NotImplementedException();

            public void Dispose()
            {
            }

            #endregion MyRegion
        }
    }
}