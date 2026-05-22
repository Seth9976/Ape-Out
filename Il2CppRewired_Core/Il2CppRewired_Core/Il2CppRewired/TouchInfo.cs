using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppRewired
{
	// Token: 0x0200002A RID: 42
	[StructLayout(2)]
	public struct TouchInfo
	{
		// Token: 0x0600033C RID: 828 RVA: 0x0003A2B4 File Offset: 0x000384B4
		// Note: this type is marked as 'beforefieldinit'.
		static TouchInfo()
		{
			Il2CppClassPointerStore<TouchInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "TouchInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchInfo>.NativeClassPtr);
			TouchInfo.NativeFieldInfoPtr_CibDydbxAnvhtrCTUItBCQCBnsqW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInfo>.NativeClassPtr, "CibDydbxAnvhtrCTUItBCQCBnsqW");
			TouchInfo.NativeFieldInfoPtr_qvglLfrcCaRxAAbrievJWNAiLQU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInfo>.NativeClassPtr, "qvglLfrcCaRxAAbrievJWNAiLQU");
			TouchInfo.NativeFieldInfoPtr_AlxQJnrNwnpuKGfjdiVrykPsHvEf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInfo>.NativeClassPtr, "AlxQJnrNwnpuKGfjdiVrykPsHvEf");
			TouchInfo.NativeFieldInfoPtr_yJBIBGWtKoqgqfigbOsQmnOxnFo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInfo>.NativeClassPtr, "yJBIBGWtKoqgqfigbOsQmnOxnFo");
			TouchInfo.NativeFieldInfoPtr_glAGPGTtCtckqrLneUeEpWwQtok = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInfo>.NativeClassPtr, "glAGPGTtCtckqrLneUeEpWwQtok");
			TouchInfo.NativeFieldInfoPtr_qRjGBUtGXgisdMepEgNaEYLmSAjm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInfo>.NativeClassPtr, "qRjGBUtGXgisdMepEgNaEYLmSAjm");
			TouchInfo.NativeFieldInfoPtr_eyvFWFEVUMMDpbpqGzQobMkvxSlu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInfo>.NativeClassPtr, "eyvFWFEVUMMDpbpqGzQobMkvxSlu");
			TouchInfo.NativeFieldInfoPtr_uWJxPJfQkygnQJChDxFDkeSdQnfh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInfo>.NativeClassPtr, "uWJxPJfQkygnQJChDxFDkeSdQnfh");
			TouchInfo.NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInfo>.NativeClassPtr, 100663826);
			TouchInfo.NativeMethodInfoPtr_set_isValid_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInfo>.NativeClassPtr, 100663827);
			TouchInfo.NativeMethodInfoPtr_get_touchId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInfo>.NativeClassPtr, 100663828);
			TouchInfo.NativeMethodInfoPtr_set_touchId_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInfo>.NativeClassPtr, 100663829);
			TouchInfo.NativeMethodInfoPtr_get_touchPos_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInfo>.NativeClassPtr, 100663830);
			TouchInfo.NativeMethodInfoPtr_set_touchPos_Internal_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInfo>.NativeClassPtr, 100663831);
			TouchInfo.NativeMethodInfoPtr_get_touchPosRaw_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInfo>.NativeClassPtr, 100663832);
			TouchInfo.NativeMethodInfoPtr_set_touchPosRaw_Internal_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInfo>.NativeClassPtr, 100663833);
			TouchInfo.NativeMethodInfoPtr_get_deltaPos_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInfo>.NativeClassPtr, 100663834);
			TouchInfo.NativeMethodInfoPtr_set_deltaPos_Internal_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInfo>.NativeClassPtr, 100663835);
			TouchInfo.NativeMethodInfoPtr_get_deltaPosRaw_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInfo>.NativeClassPtr, 100663836);
			TouchInfo.NativeMethodInfoPtr_set_deltaPosRaw_Internal_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInfo>.NativeClassPtr, 100663837);
			TouchInfo.NativeMethodInfoPtr_get_deltaTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInfo>.NativeClassPtr, 100663838);
			TouchInfo.NativeMethodInfoPtr_set_deltaTime_Internal_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInfo>.NativeClassPtr, 100663839);
			TouchInfo.NativeMethodInfoPtr_get_tapCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInfo>.NativeClassPtr, 100663840);
			TouchInfo.NativeMethodInfoPtr_set_tapCount_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInfo>.NativeClassPtr, 100663841);
			TouchInfo.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_Int32_Vector2_Vector2_Vector2_Vector2_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInfo>.NativeClassPtr, 100663842);
			TouchInfo.NativeMethodInfoPtr_get_Invalid_Internal_Static_get_TouchInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInfo>.NativeClassPtr, 100663843);
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600033D RID: 829 RVA: 0x0003A4EC File Offset: 0x000386EC
		// (set) Token: 0x0600033E RID: 830 RVA: 0x0003A51C File Offset: 0x0003871C
		public unsafe bool isValid
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInfo.NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInfo.NativeMethodInfoPtr_set_isValid_Internal_set_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x0600033F RID: 831 RVA: 0x0003A550 File Offset: 0x00038750
		// (set) Token: 0x06000340 RID: 832 RVA: 0x0003A580 File Offset: 0x00038780
		public unsafe int touchId
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInfo.NativeMethodInfoPtr_get_touchId_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInfo.NativeMethodInfoPtr_set_touchId_Internal_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000341 RID: 833 RVA: 0x0003A5B4 File Offset: 0x000387B4
		// (set) Token: 0x06000342 RID: 834 RVA: 0x0003A5E4 File Offset: 0x000387E4
		public unsafe Vector2 touchPos
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInfo.NativeMethodInfoPtr_get_touchPos_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInfo.NativeMethodInfoPtr_set_touchPos_Internal_set_Void_Vector2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000343 RID: 835 RVA: 0x0003A618 File Offset: 0x00038818
		// (set) Token: 0x06000344 RID: 836 RVA: 0x0003A648 File Offset: 0x00038848
		public unsafe Vector2 touchPosRaw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInfo.NativeMethodInfoPtr_get_touchPosRaw_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInfo.NativeMethodInfoPtr_set_touchPosRaw_Internal_set_Void_Vector2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000345 RID: 837 RVA: 0x0003A67C File Offset: 0x0003887C
		// (set) Token: 0x06000346 RID: 838 RVA: 0x0003A6AC File Offset: 0x000388AC
		public unsafe Vector2 deltaPos
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInfo.NativeMethodInfoPtr_get_deltaPos_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInfo.NativeMethodInfoPtr_set_deltaPos_Internal_set_Void_Vector2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000347 RID: 839 RVA: 0x0003A6E0 File Offset: 0x000388E0
		// (set) Token: 0x06000348 RID: 840 RVA: 0x0003A710 File Offset: 0x00038910
		public unsafe Vector2 deltaPosRaw
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInfo.NativeMethodInfoPtr_get_deltaPosRaw_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInfo.NativeMethodInfoPtr_set_deltaPosRaw_Internal_set_Void_Vector2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000349 RID: 841 RVA: 0x0003A744 File Offset: 0x00038944
		// (set) Token: 0x0600034A RID: 842 RVA: 0x0003A774 File Offset: 0x00038974
		public unsafe float deltaTime
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInfo.NativeMethodInfoPtr_get_deltaTime_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInfo.NativeMethodInfoPtr_set_deltaTime_Internal_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x0600034B RID: 843 RVA: 0x0003A7A8 File Offset: 0x000389A8
		// (set) Token: 0x0600034C RID: 844 RVA: 0x0003A7D8 File Offset: 0x000389D8
		public unsafe int tapCount
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInfo.NativeMethodInfoPtr_get_tapCount_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInfo.NativeMethodInfoPtr_set_tapCount_Internal_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0003A80C File Offset: 0x00038A0C
		[CallerCount(0)]
		public unsafe TouchInfo(bool isValid, int touchId, Vector2 touchPos, Vector2 touchPosRaw, Vector2 deltaPos, Vector2 deltaPosRaw, float deltaTime, int tapCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isValid;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref touchId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref touchPos;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref touchPosRaw;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaPos;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaPosRaw;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tapCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInfo.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_Int32_Vector2_Vector2_Vector2_Vector2_Single_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x0600034E RID: 846 RVA: 0x0003A8A0 File Offset: 0x00038AA0
		public unsafe static TouchInfo Invalid
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInfo.NativeMethodInfoPtr_get_Invalid_Internal_Static_get_TouchInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00003112 File Offset: 0x00001312
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TouchInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeFieldInfoPtr_CibDydbxAnvhtrCTUItBCQCBnsqW;

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeFieldInfoPtr_qvglLfrcCaRxAAbrievJWNAiLQU;

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeFieldInfoPtr_AlxQJnrNwnpuKGfjdiVrykPsHvEf;

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeFieldInfoPtr_yJBIBGWtKoqgqfigbOsQmnOxnFo;

		// Token: 0x040002BA RID: 698
		private static readonly IntPtr NativeFieldInfoPtr_glAGPGTtCtckqrLneUeEpWwQtok;

		// Token: 0x040002BB RID: 699
		private static readonly IntPtr NativeFieldInfoPtr_qRjGBUtGXgisdMepEgNaEYLmSAjm;

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeFieldInfoPtr_eyvFWFEVUMMDpbpqGzQobMkvxSlu;

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeFieldInfoPtr_uWJxPJfQkygnQJChDxFDkeSdQnfh;

		// Token: 0x040002BE RID: 702
		private static readonly IntPtr NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0;

		// Token: 0x040002BF RID: 703
		private static readonly IntPtr NativeMethodInfoPtr_set_isValid_Internal_set_Void_Boolean_0;

		// Token: 0x040002C0 RID: 704
		private static readonly IntPtr NativeMethodInfoPtr_get_touchId_Public_get_Int32_0;

		// Token: 0x040002C1 RID: 705
		private static readonly IntPtr NativeMethodInfoPtr_set_touchId_Internal_set_Void_Int32_0;

		// Token: 0x040002C2 RID: 706
		private static readonly IntPtr NativeMethodInfoPtr_get_touchPos_Public_get_Vector2_0;

		// Token: 0x040002C3 RID: 707
		private static readonly IntPtr NativeMethodInfoPtr_set_touchPos_Internal_set_Void_Vector2_0;

		// Token: 0x040002C4 RID: 708
		private static readonly IntPtr NativeMethodInfoPtr_get_touchPosRaw_Public_get_Vector2_0;

		// Token: 0x040002C5 RID: 709
		private static readonly IntPtr NativeMethodInfoPtr_set_touchPosRaw_Internal_set_Void_Vector2_0;

		// Token: 0x040002C6 RID: 710
		private static readonly IntPtr NativeMethodInfoPtr_get_deltaPos_Public_get_Vector2_0;

		// Token: 0x040002C7 RID: 711
		private static readonly IntPtr NativeMethodInfoPtr_set_deltaPos_Internal_set_Void_Vector2_0;

		// Token: 0x040002C8 RID: 712
		private static readonly IntPtr NativeMethodInfoPtr_get_deltaPosRaw_Public_get_Vector2_0;

		// Token: 0x040002C9 RID: 713
		private static readonly IntPtr NativeMethodInfoPtr_set_deltaPosRaw_Internal_set_Void_Vector2_0;

		// Token: 0x040002CA RID: 714
		private static readonly IntPtr NativeMethodInfoPtr_get_deltaTime_Public_get_Single_0;

		// Token: 0x040002CB RID: 715
		private static readonly IntPtr NativeMethodInfoPtr_set_deltaTime_Internal_set_Void_Single_0;

		// Token: 0x040002CC RID: 716
		private static readonly IntPtr NativeMethodInfoPtr_get_tapCount_Public_get_Int32_0;

		// Token: 0x040002CD RID: 717
		private static readonly IntPtr NativeMethodInfoPtr_set_tapCount_Internal_set_Void_Int32_0;

		// Token: 0x040002CE RID: 718
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_Int32_Vector2_Vector2_Vector2_Vector2_Single_Int32_0;

		// Token: 0x040002CF RID: 719
		private static readonly IntPtr NativeMethodInfoPtr_get_Invalid_Internal_Static_get_TouchInfo_0;

		// Token: 0x040002D0 RID: 720
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool CibDydbxAnvhtrCTUItBCQCBnsqW;

		// Token: 0x040002D1 RID: 721
		[FieldOffset(4)]
		public int qvglLfrcCaRxAAbrievJWNAiLQU;

		// Token: 0x040002D2 RID: 722
		[FieldOffset(8)]
		public Vector2 AlxQJnrNwnpuKGfjdiVrykPsHvEf;

		// Token: 0x040002D3 RID: 723
		[FieldOffset(16)]
		public Vector2 yJBIBGWtKoqgqfigbOsQmnOxnFo;

		// Token: 0x040002D4 RID: 724
		[FieldOffset(24)]
		public Vector2 glAGPGTtCtckqrLneUeEpWwQtok;

		// Token: 0x040002D5 RID: 725
		[FieldOffset(32)]
		public Vector2 qRjGBUtGXgisdMepEgNaEYLmSAjm;

		// Token: 0x040002D6 RID: 726
		[FieldOffset(40)]
		public float eyvFWFEVUMMDpbpqGzQobMkvxSlu;

		// Token: 0x040002D7 RID: 727
		[FieldOffset(44)]
		public int uWJxPJfQkygnQJChDxFDkeSdQnfh;
	}
}
