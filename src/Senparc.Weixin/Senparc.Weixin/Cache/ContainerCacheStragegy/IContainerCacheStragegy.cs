﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Senparc.Weixin.Containers;

namespace Senparc.Weixin.Cache
{
    /// <summary>
    /// 容器缓存策略接口
    /// </summary>
    public interface IContainerCacheStragegy : IBaseCacheStrategy<string, IBaseContainerBag>, ICacheLock

    {
        /// <summary>
        /// 获取缓存中最终的键，建议格式： return String.Format("{0}:{1}", "SenparcWeixinContainer", key);
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        string GetFinalKey(string key);

        /// <summary>
        /// 获取所有ContainerBag
        /// </summary>
        /// <typeparam name="TBag"></typeparam>
        /// <returns></returns>
        IDictionary<string, TBag> GetAll<TBag>() where TBag : IBaseContainerBag;

        /// <summary>
        /// 更新ContainerBag
        /// </summary>
        /// <param name="key"></param>
        /// <param name="containerBag"></param>
        void UpdateContainerBag(string key, IBaseContainerBag containerBag);
    }
}
