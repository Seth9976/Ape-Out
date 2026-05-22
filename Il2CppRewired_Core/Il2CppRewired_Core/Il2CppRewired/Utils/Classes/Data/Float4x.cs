using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppRewired.Utils.Classes.Data
{
	// Token: 0x020001CD RID: 461
	[Serializable]
	[StructLayout(2)]
	public struct Float4x
	{
		// Token: 0x0600305E RID: 12382 RVA: 0x000F0608 File Offset: 0x000EE808
		// Note: this type is marked as 'beforefieldinit'.
		static Float4x()
		{
			Il2CppClassPointerStore<Float4x>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Classes.Data", "Float4x");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Float4x>.NativeClassPtr);
			Float4x.NativeFieldInfoPtr_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Float4x>.NativeClassPtr, "Length");
			Float4x.NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Float4x>.NativeClassPtr, "a");
			Float4x.NativeFieldInfoPtr_b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Float4x>.NativeClassPtr, "b");
			Float4x.NativeFieldInfoPtr_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Float4x>.NativeClassPtr, "c");
			Float4x.NativeFieldInfoPtr_d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Float4x>.NativeClassPtr, "d");
			Float4x.NativeFieldInfoPtr__additionDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Float4x>.NativeClassPtr, "_additionDelegate");
			Float4x.NativeFieldInfoPtr__subtractionDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Float4x>.NativeClassPtr, "_subtractionDelegate");
			Float4x.NativeFieldInfoPtr__multiplicationDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Float4x>.NativeClassPtr, "_multiplicationDelegate");
			Float4x.NativeFieldInfoPtr__divisionDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Float4x>.NativeClassPtr, "_divisionDelegate");
			Float4x.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float4x>.NativeClassPtr, 100675655);
			Float4x.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float4x>.NativeClassPtr, 100675656);
			Float4x.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float4x>.NativeClassPtr, 100675657);
			Float4x.NativeMethodInfoPtr_Clone_Public_Float4x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float4x>.NativeClassPtr, 100675658);
			Float4x.NativeMethodInfoPtr_Clone_Public_Static_Float4x_Float4x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float4x>.NativeClassPtr, 100675659);
			Float4x.NativeMethodInfoPtr_get_Zero_Public_Static_get_Float4x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float4x>.NativeClassPtr, 100675660);
			Float4x.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float4x>.NativeClassPtr, 100675661);
			Float4x.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float4x>.NativeClassPtr, 100675662);
			Float4x.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Float4x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float4x>.NativeClassPtr, 100675663);
			Float4x.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float4x>.NativeClassPtr, 100675664);
			Float4x.NativeMethodInfoPtr_Add_Public_Static_Float4x_Float4x_Float4x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float4x>.NativeClassPtr, 100675665);
			Float4x.NativeMethodInfoPtr_Subtract_Public_Static_Float4x_Float4x_Float4x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float4x>.NativeClassPtr, 100675666);
			Float4x.NativeMethodInfoPtr_Multiply_Public_Static_Float4x_Float4x_Float4x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float4x>.NativeClassPtr, 100675667);
			Float4x.NativeMethodInfoPtr_Divide_Public_Static_Float4x_Float4x_Float4x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float4x>.NativeClassPtr, 100675668);
			Float4x.NativeMethodInfoPtr_GetAdditionDelegate_Public_Static_Func_3_Float4x_Float4x_Float4x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float4x>.NativeClassPtr, 100675669);
			Float4x.NativeMethodInfoPtr_GetSubtractionDelegate_Public_Static_Func_3_Float4x_Float4x_Float4x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float4x>.NativeClassPtr, 100675670);
			Float4x.NativeMethodInfoPtr_GetMultiplicationDelegate_Public_Static_Func_3_Float4x_Float4x_Float4x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float4x>.NativeClassPtr, 100675671);
			Float4x.NativeMethodInfoPtr_GetDivisionDelegate_Public_Static_Func_3_Float4x_Float4x_Float4x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float4x>.NativeClassPtr, 100675672);
			Float4x.NativeMethodInfoPtr_op_Implicit_Public_Static_Float4x_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float4x>.NativeClassPtr, 100675673);
			Float4x.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_Float4x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float4x>.NativeClassPtr, 100675674);
			Float4x.NativeMethodInfoPtr_op_Addition_Public_Static_Float4x_Float4x_Float4x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float4x>.NativeClassPtr, 100675675);
			Float4x.NativeMethodInfoPtr_op_Subtraction_Public_Static_Float4x_Float4x_Float4x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float4x>.NativeClassPtr, 100675676);
			Float4x.NativeMethodInfoPtr_op_Multiply_Public_Static_Float4x_Float4x_Float4x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float4x>.NativeClassPtr, 100675677);
			Float4x.NativeMethodInfoPtr_op_Division_Public_Static_Float4x_Float4x_Float4x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float4x>.NativeClassPtr, 100675678);
			Float4x.NativeMethodInfoPtr_op_Addition_Public_Static_Float4x_Float4x_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float4x>.NativeClassPtr, 100675679);
			Float4x.NativeMethodInfoPtr_op_Subtraction_Public_Static_Float4x_Float4x_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float4x>.NativeClassPtr, 100675680);
			Float4x.NativeMethodInfoPtr_op_Multiply_Public_Static_Float4x_Float4x_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float4x>.NativeClassPtr, 100675681);
			Float4x.NativeMethodInfoPtr_op_Division_Public_Static_Float4x_Float4x_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float4x>.NativeClassPtr, 100675682);
		}

		// Token: 0x17000F0A RID: 3850
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float4x.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0, ref this, (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float4x.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003061 RID: 12385 RVA: 0x000F099C File Offset: 0x000EEB9C
		[CallerCount(0)]
		public unsafe Float4x(float a, float b, float c, float d)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float4x.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003062 RID: 12386 RVA: 0x000F09F8 File Offset: 0x000EEBF8
		[CallerCount(0)]
		public unsafe Float4x Clone()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float4x.NativeMethodInfoPtr_Clone_Public_Float4x_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003063 RID: 12387 RVA: 0x000F0A28 File Offset: 0x000EEC28
		[CallerCount(0)]
		public unsafe static Float4x Clone(Float4x obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float4x.NativeMethodInfoPtr_Clone_Public_Static_Float4x_Float4x_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F0B RID: 3851
		// (get) Token: 0x06003064 RID: 12388 RVA: 0x000F0A68 File Offset: 0x000EEC68
		public unsafe static Float4x Zero
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float4x.NativeMethodInfoPtr_get_Zero_Public_Static_get_Float4x_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003065 RID: 12389 RVA: 0x000F0A98 File Offset: 0x000EEC98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335245, XrefRangeEnd = 335247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(global::Il2CppSystem.Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float4x.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003066 RID: 12390 RVA: 0x000F0ADC File Offset: 0x000EECDC
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float4x.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003067 RID: 12391 RVA: 0x000F0B0C File Offset: 0x000EED0C
		[CallerCount(0)]
		public unsafe bool Equals(Float4x other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float4x.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Float4x_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003068 RID: 12392 RVA: 0x000F0B4C File Offset: 0x000EED4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335247, XrefRangeEnd = 335296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float4x.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003069 RID: 12393 RVA: 0x000F0B78 File Offset: 0x000EED78
		[CallerCount(0)]
		public unsafe static Float4x Add(Float4x value1, Float4x value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float4x.NativeMethodInfoPtr_Add_Public_Static_Float4x_Float4x_Float4x_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600306A RID: 12394 RVA: 0x000F0BC4 File Offset: 0x000EEDC4
		[CallerCount(0)]
		public unsafe static Float4x Subtract(Float4x value1, Float4x value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float4x.NativeMethodInfoPtr_Subtract_Public_Static_Float4x_Float4x_Float4x_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600306B RID: 12395 RVA: 0x000F0C10 File Offset: 0x000EEE10
		[CallerCount(0)]
		public unsafe static Float4x Multiply(Float4x value1, Float4x value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float4x.NativeMethodInfoPtr_Multiply_Public_Static_Float4x_Float4x_Float4x_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600306C RID: 12396 RVA: 0x000F0C5C File Offset: 0x000EEE5C
		[CallerCount(0)]
		public unsafe static Float4x Divide(Float4x value1, Float4x value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float4x.NativeMethodInfoPtr_Divide_Public_Static_Float4x_Float4x_Float4x_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600306D RID: 12397 RVA: 0x000F0CA8 File Offset: 0x000EEEA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335296, XrefRangeEnd = 335307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Func<Float4x, Float4x, Float4x> GetAdditionDelegate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float4x.NativeMethodInfoPtr_GetAdditionDelegate_Public_Static_Func_3_Float4x_Float4x_Float4x_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Float4x, Float4x, Float4x>>(intPtr3) : null;
		}

		// Token: 0x0600306E RID: 12398 RVA: 0x000F0CDC File Offset: 0x000EEEDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335307, XrefRangeEnd = 335318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Func<Float4x, Float4x, Float4x> GetSubtractionDelegate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float4x.NativeMethodInfoPtr_GetSubtractionDelegate_Public_Static_Func_3_Float4x_Float4x_Float4x_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Float4x, Float4x, Float4x>>(intPtr3) : null;
		}

		// Token: 0x0600306F RID: 12399 RVA: 0x000F0D10 File Offset: 0x000EEF10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335318, XrefRangeEnd = 335329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Func<Float4x, Float4x, Float4x> GetMultiplicationDelegate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float4x.NativeMethodInfoPtr_GetMultiplicationDelegate_Public_Static_Func_3_Float4x_Float4x_Float4x_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Float4x, Float4x, Float4x>>(intPtr3) : null;
		}

		// Token: 0x06003070 RID: 12400 RVA: 0x000F0D44 File Offset: 0x000EEF44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335329, XrefRangeEnd = 335340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Func<Float4x, Float4x, Float4x> GetDivisionDelegate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float4x.NativeMethodInfoPtr_GetDivisionDelegate_Public_Static_Func_3_Float4x_Float4x_Float4x_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Float4x, Float4x, Float4x>>(intPtr3) : null;
		}

		// Token: 0x06003071 RID: 12401 RVA: 0x000F0D78 File Offset: 0x000EEF78
		[CallerCount(0)]
		public unsafe static implicit operator Float4x(Vector4 obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float4x.NativeMethodInfoPtr_op_Implicit_Public_Static_Float4x_Vector4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003072 RID: 12402 RVA: 0x000F0DB8 File Offset: 0x000EEFB8
		[CallerCount(0)]
		public unsafe static implicit operator Vector4(Float4x obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float4x.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_Float4x_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003073 RID: 12403 RVA: 0x000F0DF8 File Offset: 0x000EEFF8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 335340, RefRangeEnd = 335343, XrefRangeStart = 335340, XrefRangeEnd = 335340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Float4x operator +(Float4x value1, Float4x value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float4x.NativeMethodInfoPtr_op_Addition_Public_Static_Float4x_Float4x_Float4x_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003074 RID: 12404 RVA: 0x000F0E44 File Offset: 0x000EF044
		[CallerCount(0)]
		public unsafe static Float4x operator -(Float4x value1, Float4x value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float4x.NativeMethodInfoPtr_op_Subtraction_Public_Static_Float4x_Float4x_Float4x_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003075 RID: 12405 RVA: 0x000F0E90 File Offset: 0x000EF090
		[CallerCount(0)]
		public unsafe static Float4x operator *(Float4x value1, Float4x value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float4x.NativeMethodInfoPtr_op_Multiply_Public_Static_Float4x_Float4x_Float4x_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003076 RID: 12406 RVA: 0x000F0EDC File Offset: 0x000EF0DC
		[CallerCount(0)]
		public unsafe static Float4x operator /(Float4x value1, Float4x value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float4x.NativeMethodInfoPtr_op_Division_Public_Static_Float4x_Float4x_Float4x_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003077 RID: 12407 RVA: 0x000F0F28 File Offset: 0x000EF128
		[CallerCount(0)]
		public unsafe static Float4x operator +(Float4x value1, float value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float4x.NativeMethodInfoPtr_op_Addition_Public_Static_Float4x_Float4x_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003078 RID: 12408 RVA: 0x000F0F74 File Offset: 0x000EF174
		[CallerCount(0)]
		public unsafe static Float4x operator -(Float4x value1, float value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float4x.NativeMethodInfoPtr_op_Subtraction_Public_Static_Float4x_Float4x_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003079 RID: 12409 RVA: 0x000F0FC0 File Offset: 0x000EF1C0
		[CallerCount(0)]
		public unsafe static Float4x operator *(Float4x value1, float value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float4x.NativeMethodInfoPtr_op_Multiply_Public_Static_Float4x_Float4x_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600307A RID: 12410 RVA: 0x000F100C File Offset: 0x000EF20C
		[CallerCount(0)]
		public unsafe static Float4x operator /(Float4x value1, float value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float4x.NativeMethodInfoPtr_op_Division_Public_Static_Float4x_Float4x_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600307B RID: 12411 RVA: 0x00011733 File Offset: 0x0000F933
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Float4x>.NativeClassPtr, ref this));
		}

		// Token: 0x17000F05 RID: 3845
		// (get) Token: 0x0600307C RID: 12412 RVA: 0x000F1058 File Offset: 0x000EF258
		// (set) Token: 0x0600307D RID: 12413 RVA: 0x00011745 File Offset: 0x0000F945
		public unsafe static int Length
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Float4x.NativeFieldInfoPtr_Length, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Float4x.NativeFieldInfoPtr_Length, (void*)(&value));
			}
		}

		// Token: 0x17000F06 RID: 3846
		// (get) Token: 0x0600307E RID: 12414 RVA: 0x000F1074 File Offset: 0x000EF274
		// (set) Token: 0x0600307F RID: 12415 RVA: 0x00011753 File Offset: 0x0000F953
		public unsafe static Func<Float4x, Float4x, Float4x> _additionDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Float4x.NativeFieldInfoPtr__additionDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Float4x, Float4x, Float4x>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Float4x.NativeFieldInfoPtr__additionDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F07 RID: 3847
		// (get) Token: 0x06003080 RID: 12416 RVA: 0x000F109C File Offset: 0x000EF29C
		// (set) Token: 0x06003081 RID: 12417 RVA: 0x00011765 File Offset: 0x0000F965
		public unsafe static Func<Float4x, Float4x, Float4x> _subtractionDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Float4x.NativeFieldInfoPtr__subtractionDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Float4x, Float4x, Float4x>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Float4x.NativeFieldInfoPtr__subtractionDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F08 RID: 3848
		// (get) Token: 0x06003082 RID: 12418 RVA: 0x000F10C4 File Offset: 0x000EF2C4
		// (set) Token: 0x06003083 RID: 12419 RVA: 0x00011777 File Offset: 0x0000F977
		public unsafe static Func<Float4x, Float4x, Float4x> _multiplicationDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Float4x.NativeFieldInfoPtr__multiplicationDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Float4x, Float4x, Float4x>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Float4x.NativeFieldInfoPtr__multiplicationDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F09 RID: 3849
		// (get) Token: 0x06003084 RID: 12420 RVA: 0x000F10EC File Offset: 0x000EF2EC
		// (set) Token: 0x06003085 RID: 12421 RVA: 0x00011789 File Offset: 0x0000F989
		public unsafe static Func<Float4x, Float4x, Float4x> _divisionDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Float4x.NativeFieldInfoPtr__divisionDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Float4x, Float4x, Float4x>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Float4x.NativeFieldInfoPtr__divisionDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002929 RID: 10537
		private static readonly IntPtr NativeFieldInfoPtr_Length;

		// Token: 0x0400292A RID: 10538
		private static readonly IntPtr NativeFieldInfoPtr_a;

		// Token: 0x0400292B RID: 10539
		private static readonly IntPtr NativeFieldInfoPtr_b;

		// Token: 0x0400292C RID: 10540
		private static readonly IntPtr NativeFieldInfoPtr_c;

		// Token: 0x0400292D RID: 10541
		private static readonly IntPtr NativeFieldInfoPtr_d;

		// Token: 0x0400292E RID: 10542
		private static readonly IntPtr NativeFieldInfoPtr__additionDelegate;

		// Token: 0x0400292F RID: 10543
		private static readonly IntPtr NativeFieldInfoPtr__subtractionDelegate;

		// Token: 0x04002930 RID: 10544
		private static readonly IntPtr NativeFieldInfoPtr__multiplicationDelegate;

		// Token: 0x04002931 RID: 10545
		private static readonly IntPtr NativeFieldInfoPtr__divisionDelegate;

		// Token: 0x04002932 RID: 10546
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0;

		// Token: 0x04002933 RID: 10547
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0;

		// Token: 0x04002934 RID: 10548
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;

		// Token: 0x04002935 RID: 10549
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Float4x_0;

		// Token: 0x04002936 RID: 10550
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Static_Float4x_Float4x_0;

		// Token: 0x04002937 RID: 10551
		private static readonly IntPtr NativeMethodInfoPtr_get_Zero_Public_Static_get_Float4x_0;

		// Token: 0x04002938 RID: 10552
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002939 RID: 10553
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400293A RID: 10554
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Float4x_0;

		// Token: 0x0400293B RID: 10555
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400293C RID: 10556
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Static_Float4x_Float4x_Float4x_0;

		// Token: 0x0400293D RID: 10557
		private static readonly IntPtr NativeMethodInfoPtr_Subtract_Public_Static_Float4x_Float4x_Float4x_0;

		// Token: 0x0400293E RID: 10558
		private static readonly IntPtr NativeMethodInfoPtr_Multiply_Public_Static_Float4x_Float4x_Float4x_0;

		// Token: 0x0400293F RID: 10559
		private static readonly IntPtr NativeMethodInfoPtr_Divide_Public_Static_Float4x_Float4x_Float4x_0;

		// Token: 0x04002940 RID: 10560
		private static readonly IntPtr NativeMethodInfoPtr_GetAdditionDelegate_Public_Static_Func_3_Float4x_Float4x_Float4x_0;

		// Token: 0x04002941 RID: 10561
		private static readonly IntPtr NativeMethodInfoPtr_GetSubtractionDelegate_Public_Static_Func_3_Float4x_Float4x_Float4x_0;

		// Token: 0x04002942 RID: 10562
		private static readonly IntPtr NativeMethodInfoPtr_GetMultiplicationDelegate_Public_Static_Func_3_Float4x_Float4x_Float4x_0;

		// Token: 0x04002943 RID: 10563
		private static readonly IntPtr NativeMethodInfoPtr_GetDivisionDelegate_Public_Static_Func_3_Float4x_Float4x_Float4x_0;

		// Token: 0x04002944 RID: 10564
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Float4x_Vector4_0;

		// Token: 0x04002945 RID: 10565
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_Float4x_0;

		// Token: 0x04002946 RID: 10566
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Float4x_Float4x_Float4x_0;

		// Token: 0x04002947 RID: 10567
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Float4x_Float4x_Float4x_0;

		// Token: 0x04002948 RID: 10568
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Float4x_Float4x_Float4x_0;

		// Token: 0x04002949 RID: 10569
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_Float4x_Float4x_Float4x_0;

		// Token: 0x0400294A RID: 10570
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Float4x_Float4x_Single_0;

		// Token: 0x0400294B RID: 10571
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Float4x_Float4x_Single_0;

		// Token: 0x0400294C RID: 10572
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Float4x_Float4x_Single_0;

		// Token: 0x0400294D RID: 10573
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_Float4x_Float4x_Single_0;

		// Token: 0x0400294E RID: 10574
		[FieldOffset(0)]
		public float a;

		// Token: 0x0400294F RID: 10575
		[FieldOffset(4)]
		public float b;

		// Token: 0x04002950 RID: 10576
		[FieldOffset(8)]
		public float c;

		// Token: 0x04002951 RID: 10577
		[FieldOffset(12)]
		public float d;
	}
}
