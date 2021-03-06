﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToolGood.Algorithm
{
    /// <summary>
    /// 操作数
    /// </summary>
    public class Operand
    {
        #region Constructed Function
        public Operand(OperandType type, object value)
        {
            this.Type = type;

            this.Value = value;
        }
        public Operand(OperandType type, short value)
        {
            this.Type = type;
            this.Value = (double)value;
        }
        public Operand(OperandType type, int value)
        {
            this.Type = type;
            this.Value = (double)value;
        }
        public Operand(OperandType type, long value)
        {
            this.Type = type;
            this.Value = (double)value;
        }
        public Operand(OperandType type, ushort value)
        {
            this.Type = type;
            this.Value = (double)value;
        }
        public Operand(OperandType type, uint value)
        {
            this.Type = type;
            this.Value = (double)value;
        }
        public Operand(OperandType type, ulong value)
        {
            this.Type = type;
            this.Value = (double)value;
        }
        public Operand(OperandType type, float value)
        {
            this.Type = type;
            this.Value = (double)value;
        }
        public Operand(OperandType type, double value)
        {
            this.Type = type;
            this.Value = (double)value;
        }
        public Operand(OperandType type, DateTime value)
        {
            this.Type = type;
            this.Value = (Date)value;
        }
        internal Operand(OperandType type, Date value)
        {
            this.Type = type;
            this.Value = (Date)value;
        }
        public Operand(OperandType type, string value)
        {
            this.Type = type;
            this.Value = value;
        }
        public Operand(OperandType type, bool value)
        {
            this.Type = type;
            this.Value = value;
        }
        public Operand(List<Operand> value)
        {
            this.Type = OperandType.ARRARY;
            this.Value = value;
        }


        internal Operand(string opd)
        {
            var lopd = opd.ToLower();
            if (lopd == "pi") {
                this.Type = OperandType.NUMBER;
                this.Value = Math.PI;
            } else if (lopd == "e") {
                this.Type = OperandType.NUMBER;
                this.Value = Math.E;
            } else if (lopd == "true") {
                this.Type = OperandType.BOOLEAN;
                this.Value = true;
            } else if (lopd == "false") {
                this.Type = OperandType.BOOLEAN;
                this.Value = false;
            } else {
                this.Type = ConvertOperand(opd);
                if (this.Type == OperandType.STRING) {
                    opd = FormatString(opd);
                    this.Value = opd;
                } else if (this.Type == OperandType.BOOLEAN) {
                    this.Value = bool.Parse(opd);
                } else if (this.Type == OperandType.NUMBER) {
                    this.Value = double.Parse(opd);
                } else if (this.Type == OperandType.DATE) {
                    this.Value = new Date(opd);
                } else {
                    this.Value = opd;
                }
            }
        }


        #endregion

        #region Variable &　Property



        /// <summary>
        /// 操作数类型
        /// </summary>
        public OperandType Type { get; set; }

        /// <summary>
        /// 操作数值
        /// </summary>
        internal object Value { get; private set; }

        public string Parameter
        {
            get
            {
                return Value.ToString().TrimEnd();
            }
        }

        internal double NumberValue
        {
            get
            {
                if (Type == OperandType.BOOLEAN) {
                    return (bool)Value ? 1 : 0;
                }
                return (double)Value;
            }
        }
        internal string StringValue { get { return Value.ToString(); } }
        internal bool BooleanValue
        {
            get
            {
                if (Type == OperandType.NUMBER) {
                    return (double)Value == 1;
                }
                return (bool)Value;
            }
        }
        internal Date DateValue { get { return (Date)Value; } }
        internal int IntValue { get { return (int)(double)Value; } }


        internal List<double> GetNumberList()
        {
            if (Type == OperandType.NUMBER) {
                return new List<double>() { this.NumberValue };
            }
            List<double> list = new List<double>();
            var ls = Value as List<Operand>;
            foreach (var item in ls) {
                if (item.Type == OperandType.NUMBER) {
                    list.Add(item.NumberValue);
                } else if (item.Type == OperandType.ARRARY) {
                    list.AddRange(item.GetNumberList());
                }
            }
            return list;
        }


        #endregion

        private string FormatString(string opd)
        {
            if (opd.Length == 2) {
                return "";
            }
            StringBuilder sb = new StringBuilder();
            int index = 1;
            while (index < opd.Length - 1) {
                var c = opd[index++];
                if (c == '\\') {
                    var c2 = opd[index++];
                    if (c2 == 'n') {
                        sb.Append('\n');
                    } else if (c2 == 'r') {
                        sb.Append('\r');
                    } else if (c2 == 't') {
                        sb.Append('\t');
                    } else if (c2 == '0') {
                        sb.Append('\0');
                    } else if (c2 == 'v') {
                        sb.Append('\v');
                    } else {
                        sb.Append(opd[index++]);
                    }
                } else {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }


        #region Public Method
        /// <summary>
        /// 转换操作数到指定的类型
        /// </summary>
        /// <param name="opd">操作数</param>
        /// <returns>返回对应的操作数类型</returns>
        public static OperandType ConvertOperand(string opd)
        {
            if (opd[0] == '\'' || opd[0] == '\"') {
                opd = opd.Substring(1, opd.Length - 2);
                if (IsDate(opd)) {
                    return OperandType.DATE;
                }
                return OperandType.STRING;
            } else if (opd[0] == '[') {
                return OperandType.PARAMETER;
            } else if (IsNumber(opd)) {
                return OperandType.NUMBER;
            } else if (IsNumber(opd)) {
                return OperandType.BOOLEAN;
            }
            return OperandType.PARAMETER;
        }

        /// <summary>
        /// 判断对象是否为Boolean
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsBoolean(object value)
        {
            bool v;
            return bool.TryParse(value.ToString().ToLower(), out v);
        }

        /// <summary>
        /// 判断对象是否为数字
        /// </summary>
        /// <param name="value">对象值</param>
        /// <returns>是返回真,否返回假</returns>
        public static bool IsNumber(object value)
        {
            double val;
            return double.TryParse(value.ToString(), out val);
        }

        /// <summary>
        /// 判断对象是否为日期
        /// </summary>
        /// <param name="value">对象值</param>
        /// <returns>是返回真,否返回假</returns>
        public static bool IsDate(object value)
        {
            DateTime dt;
            return DateTime.TryParse(value.ToString(), out dt);
        }
        #endregion
    }
}
