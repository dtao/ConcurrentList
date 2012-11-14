using System;
using System.Collections.Generic;

namespace ConcurrentList
{
    public sealed class SynchronizedList<T> : ThreadSafeList<T>
    {
        List<T> m_list;
        int m_count;

        public SynchronizedList()
        {
            m_list = new List<T>();
        }

        public override T this[int index]
        {
            get
            {
                int count = m_count;
                if (index < 0 || index >= count)
                {
                    throw new ArgumentOutOfRangeException("index");
                }

                return m_list[index];
            }
        }

        public override int Count
        {
            get { return m_count; }
        }

        public override void Add(T element)
        {
            lock (m_list)
            {
                m_list.Add(element);
                ++m_count;
            }
        }

        public override void CopyTo(T[] array, int arrayIndex)
        {
            int count = m_count;
            m_list.CopyTo(0, array, arrayIndex, count);
        }

        #region "Protected methods"

        protected override bool IsSynchronizedBase
        {
            get { return true; }
        }

        #endregion
    }
}
