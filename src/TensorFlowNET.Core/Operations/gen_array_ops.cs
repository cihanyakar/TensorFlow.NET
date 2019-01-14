﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Tensorflow;

namespace Tensorflow
{
    public static class gen_array_ops
    {
        public static OpDefLibrary _op_def_lib = new OpDefLibrary();

        public static Tensor placeholder(TF_DataType dtype, TensorShape shape = null)
        {
            var keywords = new Dictionary<string, object>();
            keywords.Add("dtype", dtype);
            keywords.Add("shape", shape);

            var _op = _op_def_lib._apply_op_helper("Placeholder", keywords: keywords);
            var _result = _op.outputs;
            var _inputs_flat = _op.inputs;
            var _attrs = new Dictionary<string, object>();

            _attrs["dtype"] = _op.get_attr("dtype");
            _attrs["shape"] = _op.get_attr("shape");

            return new Tensor(_op, 0, dtype);
        }

        /// <summary>
        /// Return a tensor with the same shape and contents as the input tensor or value.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="name"></param>
        public static Tensor identity(Tensor input, string name = "")
        {
            var keywords = new Dictionary<string, object>();
            keywords.Add("input", input);

            var _op = _op_def_lib._apply_op_helper("Identity", name, keywords);

            return _op.outputs[0];
        }

        public static Tensor rank(Tensor input, string name = "")
        {
            var keywords = new Dictionary<string, object>();
            keywords.Add("input", input);

            var _op = _op_def_lib._apply_op_helper("Rank", name: name, keywords: keywords);

            return _op.outputs[0];
        }
    }
}
