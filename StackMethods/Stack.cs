using System;
using System.Collections.Generic;
namespace StackMethods
{
    /// <summary>
    /// Stack class contains methods to add elements,remove elements and clear all elements
    /// </summary>
    public class Stack
    {
        //List of object type
        List<object> objectList = new List<object>();

        /// <summary>
        /// Insert given input in List
        /// </summary>
        /// <param name="newObject">instance of object class</param>
        /// 
        #region Push method
        public void Push(object newObject)
        {
            objectList.Add(newObject);
        }

        #endregion

        /// <summary>
        /// removes last element from list
        /// </summary>
        /// <returns>value of removed element</returns>
        #region Pop method       
        public object Pop()
        {
            try 
            {
                int sizeOfList = objectList.Count;
                object popedObject = objectList[sizeOfList - 1];
                objectList.RemoveAt(sizeOfList - 1);
                return popedObject;
            }
            catch (ArgumentOutOfRangeException exception) 
            {
                return exception.Message;
            }
        }

        #endregion

        /// <summary>
        /// clear all elements exist in list
        /// </summary>
        /// 
        #region Clear method
        public void Clear()
        {
            objectList.Clear();
        }
        #endregion


    }
}
