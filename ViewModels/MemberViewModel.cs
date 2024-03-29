﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibreriaAdmin.ViewModels
{
    public class MemberViewModel
    {
        public class MemberBaseModel
        {
            /// <summary>
            /// 會員基底模型
            /// </summary>
            public int memberId { get; set; }
            public string memberName { get; set; }
            public string mobileNumber { get; set; }
            public string homeNumber { get; set; }
            public string city { get; set; }
            public string region { get; set; }
            public string address { get; set; }
            /// <summary>
            /// 地址
            /// 此欄唯讀
            /// </summary>
            public string CompleteAddress
            {
                get
                {
                    return city + region + address;
                }
            }
            public string email { get; set; }
            public string memberUserName { get; set; }
            public string memberPassword { get; set; }
            public DateTime? birthday { get; set; }
            public int gender { get; set; }
            public string idnumber { get; set; }
            public decimal ordersum { get; set; }
        }

        /// <summary>
        /// 取得多种商品模型
        /// </summary>
        public class MemberListResult
        {
            public List<MemberSingleResult> MemberList { get; set; }
        }

        /// <summary>
        /// 取得單一會員模型
        /// </summary>
        public class MemberSingleResult : MemberBaseModel
        {

        }

        public class GetByIdRequest
        {
            public int MemberId { get; set; }
        }
    }
}
