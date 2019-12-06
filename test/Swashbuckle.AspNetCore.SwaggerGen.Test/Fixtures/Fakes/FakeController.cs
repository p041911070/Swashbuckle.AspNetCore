﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Swashbuckle.AspNetCore.SwaggerGen.Test
{
    public class FakeController
    {
        public void ActionWithNoParameters()
        { }

        [HttpGet(Name = "SomeRouteName")]
        public void ActionWithRouteNameMetadata()
        { }

        [Obsolete]
        public void ActionWithObsoleteAttribute()
        { }

        public void ActionWithParameter(string param)
        { }

        public void ActionWithParameterWithBindNeverAttribute([BindNever]string param)
        { }

        public void ActionWithParameterWithRequiredAttribute([Required]string param)
        { }

        public void ActionWithParameterWithBindRequiredAttribute([BindRequired]string param)
        { }

        public void ActionWithOptionalParameter(string param = "someDefaultValue")
        { }

        public void ActionWithParameterWithDefaultValueAttribute([DefaultValue("someDefaultValue")]string param)
        { }

        public void ActionWithMultipleParameters(string param1, int param2)
        { }

        [Consumes("application/someMediaType")]
        public void ActionWithConsumesAttribute(string param)
        { }

        public int ActionWithReturnValue()
        {
            throw new NotImplementedException();
        }

        [Produces("application/someMediaType")]
        public int ActionWithProducesAttribute()
        {
            throw new NotImplementedException();
        }
    }
}