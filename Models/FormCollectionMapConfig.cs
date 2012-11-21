﻿using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using EmitMapper;
using EmitMapper.MappingConfiguration;
using EmitMapper.MappingConfiguration.MappingOperations;
using EmitMapper.Utils;

namespace Mxm
{
    /// <summary>
    /// 自定义映射配置器 
    /// </summary>
    public class FormCollectionMapConfig : IMappingConfigurator
    {
        public static TPostData GetPostData<TPostData>() where TPostData : class , new()
        {
            ObjectsMapper<NameValueCollection, TPostData> mapper
                = new ObjectMapperManager().GetMapper<NameValueCollection, TPostData>(new FormCollectionMapConfig());

            return mapper.Map(HttpContext.Current.Request.Form);
        }

        public IMappingOperation[] GetMappingOperations(Type from, Type to)
        {
            var members = ReflectionUtils.GetPublicFieldsAndProperties(to);
            return members
                .Select(m => new DestWriteOperation()
                            {
                                Destination = new MemberDescriptor(m),
                                Getter =
                                    (ValueGetter<object>)
                                    (
                                        (form, status) =>
                                        {
                                            FormCollection forms = new FormCollection((NameValueCollection)form);
                                            IValueProvider valueProvider = forms.ToValueProvider();
                                            ValueProviderResult res = valueProvider.GetValue(m.Name);
                                            if (res != null)
                                            {
                                                return ValueToWrite<object>.ReturnValue(res.ConvertTo(ReflectionUtils.GetMemberType(m)));
                                            }
                                            else
                                            {
                                                return ValueToWrite<object>.Skip();
                                            }
                                        }
                                    )
                            }
                )
                .ToArray();
        }

        public string GetConfigurationName()
        {
            return null;
        }

        public IRootMappingOperation GetRootMappingOperation(Type from, Type to)
        {
            return null;
        }

        public StaticConvertersManager GetStaticConvertersManager()
        {
            return null;
        }
    }
}