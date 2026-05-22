using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppRewired.Utils.Classes.Data
{
	// Token: 0x020001CB RID: 459
	[Serializable]
	[StructLayout(2)]
	public struct Float2x
	{
		// Token: 0x0600300E RID: 12302 RVA: 0x000EF054 File Offset: 0x000ED254
		// Note: this type is marked as 'beforefieldinit'.
		static Float2x()
		{
			Il2CppClassPointerStore<Float2x>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Classes.Data", "Float2x");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Float2x>.NativeClassPtr);
			Float2x.NativeFieldInfoPtr_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Float2x>.NativeClassPtr, "Length");
			Float2x.NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Float2x>.NativeClassPtr, "a");
			Float2x.NativeFieldInfoPtr_b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Float2x>.NativeClassPtr, "b");
			Float2x.NativeFieldInfoPtr__additionDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Float2x>.NativeClassPtr, "_additionDelegate");
			Float2x.NativeFieldInfoPtr__subtractionDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Float2x>.NativeClassPtr, "_subtractionDelegate");
			Float2x.NativeFieldInfoPtr__multiplicationDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Float2x>.NativeClassPtr, "_multiplicationDelegate");
			Float2x.NativeFieldInfoPtr__divisionDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Float2x>.NativeClassPtr, "_divisionDelegate");
			Float2x.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float2x>.NativeClassPtr, 100675599);
			Float2x.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float2x>.NativeClassPtr, 100675600);
			Float2x.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float2x>.NativeClassPtr, 100675601);
			Float2x.NativeMethodInfoPtr_Clone_Public_Float2x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float2x>.NativeClassPtr, 100675602);
			Float2x.NativeMethodInfoPtr_Clone_Public_Static_Float2x_Float2x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float2x>.NativeClassPtr, 100675603);
			Float2x.NativeMethodInfoPtr_get_Zero_Public_Static_get_Float2x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float2x>.NativeClassPtr, 100675604);
			Float2x.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float2x>.NativeClassPtr, 100675605);
			Float2x.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float2x>.NativeClassPtr, 100675606);
			Float2x.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Float2x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float2x>.NativeClassPtr, 100675607);
			Float2x.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float2x>.NativeClassPtr, 100675608);
			Float2x.NativeMethodInfoPtr_Add_Public_Static_Float2x_Float2x_Float2x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float2x>.NativeClassPtr, 100675609);
			Float2x.NativeMethodInfoPtr_Subtract_Public_Static_Float2x_Float2x_Float2x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float2x>.NativeClassPtr, 100675610);
			Float2x.NativeMethodInfoPtr_Multiply_Public_Static_Float2x_Float2x_Float2x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float2x>.NativeClassPtr, 100675611);
			Float2x.NativeMethodInfoPtr_Divide_Public_Static_Float2x_Float2x_Float2x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float2x>.NativeClassPtr, 100675612);
			Float2x.NativeMethodInfoPtr_GetAdditionDelegate_Public_Static_Func_3_Float2x_Float2x_Float2x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float2x>.NativeClassPtr, 100675613);
			Float2x.NativeMethodInfoPtr_GetSubtractionDelegate_Public_Static_Func_3_Float2x_Float2x_Float2x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float2x>.NativeClassPtr, 100675614);
			Float2x.NativeMethodInfoPtr_GetMultiplicationDelegate_Public_Static_Func_3_Float2x_Float2x_Float2x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float2x>.NativeClassPtr, 100675615);
			Float2x.NativeMethodInfoPtr_GetDivisionDelegate_Public_Static_Func_3_Float2x_Float2x_Float2x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float2x>.NativeClassPtr, 100675616);
			Float2x.NativeMethodInfoPtr_op_Implicit_Public_Static_Float2x_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float2x>.NativeClassPtr, 100675617);
			Float2x.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Float2x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float2x>.NativeClassPtr, 100675618);
			Float2x.NativeMethodInfoPtr_op_Addition_Public_Static_Float2x_Float2x_Float2x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float2x>.NativeClassPtr, 100675619);
			Float2x.NativeMethodInfoPtr_op_Subtraction_Public_Static_Float2x_Float2x_Float2x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float2x>.NativeClassPtr, 100675620);
			Float2x.NativeMethodInfoPtr_op_Multiply_Public_Static_Float2x_Float2x_Float2x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float2x>.NativeClassPtr, 100675621);
			Float2x.NativeMethodInfoPtr_op_Division_Public_Static_Float2x_Float2x_Float2x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float2x>.NativeClassPtr, 100675622);
			Float2x.NativeMethodInfoPtr_op_Addition_Public_Static_Float2x_Float2x_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float2x>.NativeClassPtr, 100675623);
			Float2x.NativeMethodInfoPtr_op_Subtraction_Public_Static_Float2x_Float2x_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float2x>.NativeClassPtr, 100675624);
			Float2x.NativeMethodInfoPtr_op_Multiply_Public_Static_Float2x_Float2x_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float2x>.NativeClassPtr, 100675625);
			Float2x.NativeMethodInfoPtr_op_Division_Public_Static_Float2x_Float2x_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float2x>.NativeClassPtr, 100675626);
		}

		// Token: 0x17000EFC RID: 3836
		public unsafe float this[int index]
		{
			[CallerCount(0)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float2x.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
			[CallerCount(0)]
			set
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float2x.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003011 RID: 12305 RVA: 0x000EF3C0 File Offset: 0x000ED5C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 335098, RefRangeEnd = 335099, XrefRangeStart = 335098, XrefRangeEnd = 335098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Float2x(float a, float b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float2x.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003012 RID: 12306 RVA: 0x000EF400 File Offset: 0x000ED600
		[CallerCount(0)]
		public unsafe Float2x Clone()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float2x.NativeMethodInfoPtr_Clone_Public_Float2x_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003013 RID: 12307 RVA: 0x000EF430 File Offset: 0x000ED630
		[CallerCount(0)]
		public unsafe static Float2x Clone(Float2x obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float2x.NativeMethodInfoPtr_Clone_Public_Static_Float2x_Float2x_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000EFD RID: 3837
		// (get) Token: 0x06003014 RID: 12308 RVA: 0x000EF470 File Offset: 0x000ED670
		public unsafe static Float2x Zero
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float2x.NativeMethodInfoPtr_get_Zero_Public_Static_get_Float2x_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003015 RID: 12309 RVA: 0x000EF4A0 File Offset: 0x000ED6A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335099, XrefRangeEnd = 335101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(global::Il2CppSystem.Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float2x.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003016 RID: 12310 RVA: 0x000EF4E4 File Offset: 0x000ED6E4
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float2x.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003017 RID: 12311 RVA: 0x000EF514 File Offset: 0x000ED714
		[CallerCount(0)]
		public unsafe bool Equals(Float2x other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float2x.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Float2x_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003018 RID: 12312 RVA: 0x000EF554 File Offset: 0x000ED754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335101, XrefRangeEnd = 335112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float2x.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003019 RID: 12313 RVA: 0x000EF580 File Offset: 0x000ED780
		[CallerCount(0)]
		public unsafe static Float2x Add(Float2x value1, Float2x value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float2x.NativeMethodInfoPtr_Add_Public_Static_Float2x_Float2x_Float2x_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600301A RID: 12314 RVA: 0x000EF5CC File Offset: 0x000ED7CC
		[CallerCount(0)]
		public unsafe static Float2x Subtract(Float2x value1, Float2x value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float2x.NativeMethodInfoPtr_Subtract_Public_Static_Float2x_Float2x_Float2x_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600301B RID: 12315 RVA: 0x000EF618 File Offset: 0x000ED818
		[CallerCount(0)]
		public unsafe static Float2x Multiply(Float2x value1, Float2x value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float2x.NativeMethodInfoPtr_Multiply_Public_Static_Float2x_Float2x_Float2x_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600301C RID: 12316 RVA: 0x000EF664 File Offset: 0x000ED864
		[CallerCount(0)]
		public unsafe static Float2x Divide(Float2x value1, Float2x value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float2x.NativeMethodInfoPtr_Divide_Public_Static_Float2x_Float2x_Float2x_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600301D RID: 12317 RVA: 0x000EF6B0 File Offset: 0x000ED8B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335112, XrefRangeEnd = 335123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Func<Float2x, Float2x, Float2x> GetAdditionDelegate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float2x.NativeMethodInfoPtr_GetAdditionDelegate_Public_Static_Func_3_Float2x_Float2x_Float2x_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Float2x, Float2x, Float2x>>(intPtr3) : null;
		}

		// Token: 0x0600301E RID: 12318 RVA: 0x000EF6E4 File Offset: 0x000ED8E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335123, XrefRangeEnd = 335134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Func<Float2x, Float2x, Float2x> GetSubtractionDelegate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float2x.NativeMethodInfoPtr_GetSubtractionDelegate_Public_Static_Func_3_Float2x_Float2x_Float2x_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Float2x, Float2x, Float2x>>(intPtr3) : null;
		}

		// Token: 0x0600301F RID: 12319 RVA: 0x000EF718 File Offset: 0x000ED918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335134, XrefRangeEnd = 335145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Func<Float2x, Float2x, Float2x> GetMultiplicationDelegate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float2x.NativeMethodInfoPtr_GetMultiplicationDelegate_Public_Static_Func_3_Float2x_Float2x_Float2x_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Float2x, Float2x, Float2x>>(intPtr3) : null;
		}

		// Token: 0x06003020 RID: 12320 RVA: 0x000EF74C File Offset: 0x000ED94C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335145, XrefRangeEnd = 335156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Func<Float2x, Float2x, Float2x> GetDivisionDelegate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float2x.NativeMethodInfoPtr_GetDivisionDelegate_Public_Static_Func_3_Float2x_Float2x_Float2x_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Float2x, Float2x, Float2x>>(intPtr3) : null;
		}

		// Token: 0x06003021 RID: 12321 RVA: 0x000EF780 File Offset: 0x000ED980
		[CallerCount(0)]
		public unsafe static implicit operator Float2x(Vector2 obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float2x.NativeMethodInfoPtr_op_Implicit_Public_Static_Float2x_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003022 RID: 12322 RVA: 0x000EF7C0 File Offset: 0x000ED9C0
		[CallerCount(0)]
		public unsafe static implicit operator Vector2(Float2x obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float2x.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Float2x_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003023 RID: 12323 RVA: 0x000EF800 File Offset: 0x000EDA00
		[CallerCount(0)]
		public unsafe static Float2x operator +(Float2x value1, Float2x value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float2x.NativeMethodInfoPtr_op_Addition_Public_Static_Float2x_Float2x_Float2x_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003024 RID: 12324 RVA: 0x000EF84C File Offset: 0x000EDA4C
		[CallerCount(0)]
		public unsafe static Float2x operator -(Float2x value1, Float2x value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float2x.NativeMethodInfoPtr_op_Subtraction_Public_Static_Float2x_Float2x_Float2x_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003025 RID: 12325 RVA: 0x000EF898 File Offset: 0x000EDA98
		[CallerCount(0)]
		public unsafe static Float2x operator *(Float2x value1, Float2x value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float2x.NativeMethodInfoPtr_op_Multiply_Public_Static_Float2x_Float2x_Float2x_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003026 RID: 12326 RVA: 0x000EF8E4 File Offset: 0x000EDAE4
		[CallerCount(0)]
		public unsafe static Float2x operator /(Float2x value1, Float2x value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float2x.NativeMethodInfoPtr_op_Division_Public_Static_Float2x_Float2x_Float2x_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003027 RID: 12327 RVA: 0x000EF930 File Offset: 0x000EDB30
		[CallerCount(0)]
		public unsafe static Float2x operator +(Float2x value1, float value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float2x.NativeMethodInfoPtr_op_Addition_Public_Static_Float2x_Float2x_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003028 RID: 12328 RVA: 0x000EF97C File Offset: 0x000EDB7C
		[CallerCount(0)]
		public unsafe static Float2x operator -(Float2x value1, float value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float2x.NativeMethodInfoPtr_op_Subtraction_Public_Static_Float2x_Float2x_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003029 RID: 12329 RVA: 0x000EF9C8 File Offset: 0x000EDBC8
		[CallerCount(0)]
		public unsafe static Float2x operator *(Float2x value1, float value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float2x.NativeMethodInfoPtr_op_Multiply_Public_Static_Float2x_Float2x_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600302A RID: 12330 RVA: 0x000EFA14 File Offset: 0x000EDC14
		[CallerCount(0)]
		public unsafe static Float2x operator /(Float2x value1, float value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float2x.NativeMethodInfoPtr_op_Division_Public_Static_Float2x_Float2x_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600302B RID: 12331 RVA: 0x00011663 File Offset: 0x0000F863
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Float2x>.NativeClassPtr, ref this));
		}

		// Token: 0x17000EF7 RID: 3831
		// (get) Token: 0x0600302C RID: 12332 RVA: 0x000EFA60 File Offset: 0x000EDC60
		// (set) Token: 0x0600302D RID: 12333 RVA: 0x00011675 File Offset: 0x0000F875
		public unsafe static int Length
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Float2x.NativeFieldInfoPtr_Length, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Float2x.NativeFieldInfoPtr_Length, (void*)(&value));
			}
		}

		// Token: 0x17000EF8 RID: 3832
		// (get) Token: 0x0600302E RID: 12334 RVA: 0x000EFA7C File Offset: 0x000EDC7C
		// (set) Token: 0x0600302F RID: 12335 RVA: 0x00011683 File Offset: 0x0000F883
		public unsafe static Func<Float2x, Float2x, Float2x> _additionDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Float2x.NativeFieldInfoPtr__additionDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Float2x, Float2x, Float2x>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Float2x.NativeFieldInfoPtr__additionDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EF9 RID: 3833
		// (get) Token: 0x06003030 RID: 12336 RVA: 0x000EFAA4 File Offset: 0x000EDCA4
		// (set) Token: 0x06003031 RID: 12337 RVA: 0x00011695 File Offset: 0x0000F895
		public unsafe static Func<Float2x, Float2x, Float2x> _subtractionDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Float2x.NativeFieldInfoPtr__subtractionDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Float2x, Float2x, Float2x>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Float2x.NativeFieldInfoPtr__subtractionDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EFA RID: 3834
		// (get) Token: 0x06003032 RID: 12338 RVA: 0x000EFACC File Offset: 0x000EDCCC
		// (set) Token: 0x06003033 RID: 12339 RVA: 0x000116A7 File Offset: 0x0000F8A7
		public unsafe static Func<Float2x, Float2x, Float2x> _multiplicationDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Float2x.NativeFieldInfoPtr__multiplicationDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Float2x, Float2x, Float2x>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Float2x.NativeFieldInfoPtr__multiplicationDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EFB RID: 3835
		// (get) Token: 0x06003034 RID: 12340 RVA: 0x000EFAF4 File Offset: 0x000EDCF4
		// (set) Token: 0x06003035 RID: 12341 RVA: 0x000116B9 File Offset: 0x0000F8B9
		public unsafe static Func<Float2x, Float2x, Float2x> _divisionDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Float2x.NativeFieldInfoPtr__divisionDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Float2x, Float2x, Float2x>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Float2x.NativeFieldInfoPtr__divisionDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040028DD RID: 10461
		private static readonly IntPtr NativeFieldInfoPtr_Length;

		// Token: 0x040028DE RID: 10462
		private static readonly IntPtr NativeFieldInfoPtr_a;

		// Token: 0x040028DF RID: 10463
		private static readonly IntPtr NativeFieldInfoPtr_b;

		// Token: 0x040028E0 RID: 10464
		private static readonly IntPtr NativeFieldInfoPtr__additionDelegate;

		// Token: 0x040028E1 RID: 10465
		private static readonly IntPtr NativeFieldInfoPtr__subtractionDelegate;

		// Token: 0x040028E2 RID: 10466
		private static readonly IntPtr NativeFieldInfoPtr__multiplicationDelegate;

		// Token: 0x040028E3 RID: 10467
		private static readonly IntPtr NativeFieldInfoPtr__divisionDelegate;

		// Token: 0x040028E4 RID: 10468
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0;

		// Token: 0x040028E5 RID: 10469
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0;

		// Token: 0x040028E6 RID: 10470
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;

		// Token: 0x040028E7 RID: 10471
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Float2x_0;

		// Token: 0x040028E8 RID: 10472
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Static_Float2x_Float2x_0;

		// Token: 0x040028E9 RID: 10473
		private static readonly IntPtr NativeMethodInfoPtr_get_Zero_Public_Static_get_Float2x_0;

		// Token: 0x040028EA RID: 10474
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040028EB RID: 10475
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040028EC RID: 10476
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Float2x_0;

		// Token: 0x040028ED RID: 10477
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040028EE RID: 10478
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Static_Float2x_Float2x_Float2x_0;

		// Token: 0x040028EF RID: 10479
		private static readonly IntPtr NativeMethodInfoPtr_Subtract_Public_Static_Float2x_Float2x_Float2x_0;

		// Token: 0x040028F0 RID: 10480
		private static readonly IntPtr NativeMethodInfoPtr_Multiply_Public_Static_Float2x_Float2x_Float2x_0;

		// Token: 0x040028F1 RID: 10481
		private static readonly IntPtr NativeMethodInfoPtr_Divide_Public_Static_Float2x_Float2x_Float2x_0;

		// Token: 0x040028F2 RID: 10482
		private static readonly IntPtr NativeMethodInfoPtr_GetAdditionDelegate_Public_Static_Func_3_Float2x_Float2x_Float2x_0;

		// Token: 0x040028F3 RID: 10483
		private static readonly IntPtr NativeMethodInfoPtr_GetSubtractionDelegate_Public_Static_Func_3_Float2x_Float2x_Float2x_0;

		// Token: 0x040028F4 RID: 10484
		private static readonly IntPtr NativeMethodInfoPtr_GetMultiplicationDelegate_Public_Static_Func_3_Float2x_Float2x_Float2x_0;

		// Token: 0x040028F5 RID: 10485
		private static readonly IntPtr NativeMethodInfoPtr_GetDivisionDelegate_Public_Static_Func_3_Float2x_Float2x_Float2x_0;

		// Token: 0x040028F6 RID: 10486
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Float2x_Vector2_0;

		// Token: 0x040028F7 RID: 10487
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Float2x_0;

		// Token: 0x040028F8 RID: 10488
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Float2x_Float2x_Float2x_0;

		// Token: 0x040028F9 RID: 10489
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Float2x_Float2x_Float2x_0;

		// Token: 0x040028FA RID: 10490
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Float2x_Float2x_Float2x_0;

		// Token: 0x040028FB RID: 10491
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_Float2x_Float2x_Float2x_0;

		// Token: 0x040028FC RID: 10492
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Float2x_Float2x_Single_0;

		// Token: 0x040028FD RID: 10493
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Float2x_Float2x_Single_0;

		// Token: 0x040028FE RID: 10494
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Float2x_Float2x_Single_0;

		// Token: 0x040028FF RID: 10495
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_Float2x_Float2x_Single_0;

		// Token: 0x04002900 RID: 10496
		[FieldOffset(0)]
		public float a;

		// Token: 0x04002901 RID: 10497
		[FieldOffset(4)]
		public float b;
	}
}
