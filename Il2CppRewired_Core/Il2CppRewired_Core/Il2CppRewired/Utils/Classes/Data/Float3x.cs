using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppRewired.Utils.Classes.Data
{
	// Token: 0x020001CC RID: 460
	[Serializable]
	[StructLayout(2)]
	public struct Float3x
	{
		// Token: 0x06003036 RID: 12342 RVA: 0x000EFB1C File Offset: 0x000EDD1C
		// Note: this type is marked as 'beforefieldinit'.
		static Float3x()
		{
			Il2CppClassPointerStore<Float3x>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Classes.Data", "Float3x");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Float3x>.NativeClassPtr);
			Float3x.NativeFieldInfoPtr_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Float3x>.NativeClassPtr, "Length");
			Float3x.NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Float3x>.NativeClassPtr, "a");
			Float3x.NativeFieldInfoPtr_b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Float3x>.NativeClassPtr, "b");
			Float3x.NativeFieldInfoPtr_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Float3x>.NativeClassPtr, "c");
			Float3x.NativeFieldInfoPtr__additionDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Float3x>.NativeClassPtr, "_additionDelegate");
			Float3x.NativeFieldInfoPtr__subtractionDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Float3x>.NativeClassPtr, "_subtractionDelegate");
			Float3x.NativeFieldInfoPtr__multiplicationDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Float3x>.NativeClassPtr, "_multiplicationDelegate");
			Float3x.NativeFieldInfoPtr__divisionDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Float3x>.NativeClassPtr, "_divisionDelegate");
			Float3x.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float3x>.NativeClassPtr, 100675627);
			Float3x.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float3x>.NativeClassPtr, 100675628);
			Float3x.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float3x>.NativeClassPtr, 100675629);
			Float3x.NativeMethodInfoPtr_Clone_Public_Float3x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float3x>.NativeClassPtr, 100675630);
			Float3x.NativeMethodInfoPtr_Clone_Public_Static_Float3x_Float3x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float3x>.NativeClassPtr, 100675631);
			Float3x.NativeMethodInfoPtr_get_Zero_Public_Static_get_Float3x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float3x>.NativeClassPtr, 100675632);
			Float3x.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float3x>.NativeClassPtr, 100675633);
			Float3x.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float3x>.NativeClassPtr, 100675634);
			Float3x.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Float3x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float3x>.NativeClassPtr, 100675635);
			Float3x.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float3x>.NativeClassPtr, 100675636);
			Float3x.NativeMethodInfoPtr_Add_Public_Static_Float3x_Float3x_Float3x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float3x>.NativeClassPtr, 100675637);
			Float3x.NativeMethodInfoPtr_Subtract_Public_Static_Float3x_Float3x_Float3x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float3x>.NativeClassPtr, 100675638);
			Float3x.NativeMethodInfoPtr_Multiply_Public_Static_Float3x_Float3x_Float3x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float3x>.NativeClassPtr, 100675639);
			Float3x.NativeMethodInfoPtr_Divide_Public_Static_Float3x_Float3x_Float3x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float3x>.NativeClassPtr, 100675640);
			Float3x.NativeMethodInfoPtr_GetAdditionDelegate_Public_Static_Func_3_Float3x_Float3x_Float3x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float3x>.NativeClassPtr, 100675641);
			Float3x.NativeMethodInfoPtr_GetSubtractionDelegate_Public_Static_Func_3_Float3x_Float3x_Float3x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float3x>.NativeClassPtr, 100675642);
			Float3x.NativeMethodInfoPtr_GetMultiplicationDelegate_Public_Static_Func_3_Float3x_Float3x_Float3x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float3x>.NativeClassPtr, 100675643);
			Float3x.NativeMethodInfoPtr_GetDivisionDelegate_Public_Static_Func_3_Float3x_Float3x_Float3x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float3x>.NativeClassPtr, 100675644);
			Float3x.NativeMethodInfoPtr_op_Implicit_Public_Static_Float3x_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float3x>.NativeClassPtr, 100675645);
			Float3x.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_Float3x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float3x>.NativeClassPtr, 100675646);
			Float3x.NativeMethodInfoPtr_op_Addition_Public_Static_Float3x_Float3x_Float3x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float3x>.NativeClassPtr, 100675647);
			Float3x.NativeMethodInfoPtr_op_Subtraction_Public_Static_Float3x_Float3x_Float3x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float3x>.NativeClassPtr, 100675648);
			Float3x.NativeMethodInfoPtr_op_Multiply_Public_Static_Float3x_Float3x_Float3x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float3x>.NativeClassPtr, 100675649);
			Float3x.NativeMethodInfoPtr_op_Division_Public_Static_Float3x_Float3x_Float3x_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float3x>.NativeClassPtr, 100675650);
			Float3x.NativeMethodInfoPtr_op_Addition_Public_Static_Float3x_Float3x_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float3x>.NativeClassPtr, 100675651);
			Float3x.NativeMethodInfoPtr_op_Subtraction_Public_Static_Float3x_Float3x_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float3x>.NativeClassPtr, 100675652);
			Float3x.NativeMethodInfoPtr_op_Multiply_Public_Static_Float3x_Float3x_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float3x>.NativeClassPtr, 100675653);
			Float3x.NativeMethodInfoPtr_op_Division_Public_Static_Float3x_Float3x_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float3x>.NativeClassPtr, 100675654);
		}

		// Token: 0x17000F03 RID: 3843
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float3x.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0, ref this, (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float3x.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003039 RID: 12345 RVA: 0x000EFE9C File Offset: 0x000EE09C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 335156, RefRangeEnd = 335162, XrefRangeStart = 335156, XrefRangeEnd = 335156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Float3x(float x, float y, float z)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float3x.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600303A RID: 12346 RVA: 0x000EFEEC File Offset: 0x000EE0EC
		[CallerCount(0)]
		public unsafe Float3x Clone()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float3x.NativeMethodInfoPtr_Clone_Public_Float3x_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600303B RID: 12347 RVA: 0x000EFF1C File Offset: 0x000EE11C
		[CallerCount(0)]
		public unsafe static Float3x Clone(Float3x obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float3x.NativeMethodInfoPtr_Clone_Public_Static_Float3x_Float3x_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F04 RID: 3844
		// (get) Token: 0x0600303C RID: 12348 RVA: 0x000EFF5C File Offset: 0x000EE15C
		public unsafe static Float3x Zero
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float3x.NativeMethodInfoPtr_get_Zero_Public_Static_get_Float3x_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600303D RID: 12349 RVA: 0x000EFF8C File Offset: 0x000EE18C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335162, XrefRangeEnd = 335164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(global::Il2CppSystem.Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float3x.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600303E RID: 12350 RVA: 0x000EFFD0 File Offset: 0x000EE1D0
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float3x.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600303F RID: 12351 RVA: 0x000F0000 File Offset: 0x000EE200
		[CallerCount(0)]
		public unsafe bool Equals(Float3x other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float3x.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Float3x_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003040 RID: 12352 RVA: 0x000F0040 File Offset: 0x000EE240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335164, XrefRangeEnd = 335201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float3x.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003041 RID: 12353 RVA: 0x000F006C File Offset: 0x000EE26C
		[CallerCount(0)]
		public unsafe static Float3x Add(Float3x value1, Float3x value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float3x.NativeMethodInfoPtr_Add_Public_Static_Float3x_Float3x_Float3x_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003042 RID: 12354 RVA: 0x000F00B8 File Offset: 0x000EE2B8
		[CallerCount(0)]
		public unsafe static Float3x Subtract(Float3x value1, Float3x value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float3x.NativeMethodInfoPtr_Subtract_Public_Static_Float3x_Float3x_Float3x_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003043 RID: 12355 RVA: 0x000F0104 File Offset: 0x000EE304
		[CallerCount(0)]
		public unsafe static Float3x Multiply(Float3x value1, Float3x value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float3x.NativeMethodInfoPtr_Multiply_Public_Static_Float3x_Float3x_Float3x_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003044 RID: 12356 RVA: 0x000F0150 File Offset: 0x000EE350
		[CallerCount(0)]
		public unsafe static Float3x Divide(Float3x value1, Float3x value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float3x.NativeMethodInfoPtr_Divide_Public_Static_Float3x_Float3x_Float3x_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003045 RID: 12357 RVA: 0x000F019C File Offset: 0x000EE39C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335201, XrefRangeEnd = 335212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Func<Float3x, Float3x, Float3x> GetAdditionDelegate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float3x.NativeMethodInfoPtr_GetAdditionDelegate_Public_Static_Func_3_Float3x_Float3x_Float3x_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Float3x, Float3x, Float3x>>(intPtr3) : null;
		}

		// Token: 0x06003046 RID: 12358 RVA: 0x000F01D0 File Offset: 0x000EE3D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335212, XrefRangeEnd = 335223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Func<Float3x, Float3x, Float3x> GetSubtractionDelegate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float3x.NativeMethodInfoPtr_GetSubtractionDelegate_Public_Static_Func_3_Float3x_Float3x_Float3x_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Float3x, Float3x, Float3x>>(intPtr3) : null;
		}

		// Token: 0x06003047 RID: 12359 RVA: 0x000F0204 File Offset: 0x000EE404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335223, XrefRangeEnd = 335234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Func<Float3x, Float3x, Float3x> GetMultiplicationDelegate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float3x.NativeMethodInfoPtr_GetMultiplicationDelegate_Public_Static_Func_3_Float3x_Float3x_Float3x_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Float3x, Float3x, Float3x>>(intPtr3) : null;
		}

		// Token: 0x06003048 RID: 12360 RVA: 0x000F0238 File Offset: 0x000EE438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335234, XrefRangeEnd = 335245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Func<Float3x, Float3x, Float3x> GetDivisionDelegate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float3x.NativeMethodInfoPtr_GetDivisionDelegate_Public_Static_Func_3_Float3x_Float3x_Float3x_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Float3x, Float3x, Float3x>>(intPtr3) : null;
		}

		// Token: 0x06003049 RID: 12361 RVA: 0x000F026C File Offset: 0x000EE46C
		[CallerCount(0)]
		public unsafe static implicit operator Float3x(Vector3 obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float3x.NativeMethodInfoPtr_op_Implicit_Public_Static_Float3x_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600304A RID: 12362 RVA: 0x000F02AC File Offset: 0x000EE4AC
		[CallerCount(0)]
		public unsafe static implicit operator Vector3(Float3x obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float3x.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_Float3x_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600304B RID: 12363 RVA: 0x000F02EC File Offset: 0x000EE4EC
		[CallerCount(0)]
		public unsafe static Float3x operator +(Float3x value1, Float3x value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float3x.NativeMethodInfoPtr_op_Addition_Public_Static_Float3x_Float3x_Float3x_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600304C RID: 12364 RVA: 0x000F0338 File Offset: 0x000EE538
		[CallerCount(0)]
		public unsafe static Float3x operator -(Float3x value1, Float3x value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float3x.NativeMethodInfoPtr_op_Subtraction_Public_Static_Float3x_Float3x_Float3x_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600304D RID: 12365 RVA: 0x000F0384 File Offset: 0x000EE584
		[CallerCount(0)]
		public unsafe static Float3x operator *(Float3x value1, Float3x value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float3x.NativeMethodInfoPtr_op_Multiply_Public_Static_Float3x_Float3x_Float3x_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600304E RID: 12366 RVA: 0x000F03D0 File Offset: 0x000EE5D0
		[CallerCount(0)]
		public unsafe static Float3x operator /(Float3x value1, Float3x value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float3x.NativeMethodInfoPtr_op_Division_Public_Static_Float3x_Float3x_Float3x_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600304F RID: 12367 RVA: 0x000F041C File Offset: 0x000EE61C
		[CallerCount(0)]
		public unsafe static Float3x operator +(Float3x value1, float value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float3x.NativeMethodInfoPtr_op_Addition_Public_Static_Float3x_Float3x_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003050 RID: 12368 RVA: 0x000F0468 File Offset: 0x000EE668
		[CallerCount(0)]
		public unsafe static Float3x operator -(Float3x value1, float value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float3x.NativeMethodInfoPtr_op_Subtraction_Public_Static_Float3x_Float3x_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003051 RID: 12369 RVA: 0x000F04B4 File Offset: 0x000EE6B4
		[CallerCount(0)]
		public unsafe static Float3x operator *(Float3x value1, float value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float3x.NativeMethodInfoPtr_op_Multiply_Public_Static_Float3x_Float3x_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003052 RID: 12370 RVA: 0x000F0500 File Offset: 0x000EE700
		[CallerCount(0)]
		public unsafe static Float3x operator /(Float3x value1, float value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Float3x.NativeMethodInfoPtr_op_Division_Public_Static_Float3x_Float3x_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003053 RID: 12371 RVA: 0x000116CB File Offset: 0x0000F8CB
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Float3x>.NativeClassPtr, ref this));
		}

		// Token: 0x17000EFE RID: 3838
		// (get) Token: 0x06003054 RID: 12372 RVA: 0x000F054C File Offset: 0x000EE74C
		// (set) Token: 0x06003055 RID: 12373 RVA: 0x000116DD File Offset: 0x0000F8DD
		public unsafe static int Length
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Float3x.NativeFieldInfoPtr_Length, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Float3x.NativeFieldInfoPtr_Length, (void*)(&value));
			}
		}

		// Token: 0x17000EFF RID: 3839
		// (get) Token: 0x06003056 RID: 12374 RVA: 0x000F0568 File Offset: 0x000EE768
		// (set) Token: 0x06003057 RID: 12375 RVA: 0x000116EB File Offset: 0x0000F8EB
		public unsafe static Func<Float3x, Float3x, Float3x> _additionDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Float3x.NativeFieldInfoPtr__additionDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Float3x, Float3x, Float3x>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Float3x.NativeFieldInfoPtr__additionDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F00 RID: 3840
		// (get) Token: 0x06003058 RID: 12376 RVA: 0x000F0590 File Offset: 0x000EE790
		// (set) Token: 0x06003059 RID: 12377 RVA: 0x000116FD File Offset: 0x0000F8FD
		public unsafe static Func<Float3x, Float3x, Float3x> _subtractionDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Float3x.NativeFieldInfoPtr__subtractionDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Float3x, Float3x, Float3x>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Float3x.NativeFieldInfoPtr__subtractionDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F01 RID: 3841
		// (get) Token: 0x0600305A RID: 12378 RVA: 0x000F05B8 File Offset: 0x000EE7B8
		// (set) Token: 0x0600305B RID: 12379 RVA: 0x0001170F File Offset: 0x0000F90F
		public unsafe static Func<Float3x, Float3x, Float3x> _multiplicationDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Float3x.NativeFieldInfoPtr__multiplicationDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Float3x, Float3x, Float3x>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Float3x.NativeFieldInfoPtr__multiplicationDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F02 RID: 3842
		// (get) Token: 0x0600305C RID: 12380 RVA: 0x000F05E0 File Offset: 0x000EE7E0
		// (set) Token: 0x0600305D RID: 12381 RVA: 0x00011721 File Offset: 0x0000F921
		public unsafe static Func<Float3x, Float3x, Float3x> _divisionDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Float3x.NativeFieldInfoPtr__divisionDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Float3x, Float3x, Float3x>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Float3x.NativeFieldInfoPtr__divisionDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002902 RID: 10498
		private static readonly IntPtr NativeFieldInfoPtr_Length;

		// Token: 0x04002903 RID: 10499
		private static readonly IntPtr NativeFieldInfoPtr_a;

		// Token: 0x04002904 RID: 10500
		private static readonly IntPtr NativeFieldInfoPtr_b;

		// Token: 0x04002905 RID: 10501
		private static readonly IntPtr NativeFieldInfoPtr_c;

		// Token: 0x04002906 RID: 10502
		private static readonly IntPtr NativeFieldInfoPtr__additionDelegate;

		// Token: 0x04002907 RID: 10503
		private static readonly IntPtr NativeFieldInfoPtr__subtractionDelegate;

		// Token: 0x04002908 RID: 10504
		private static readonly IntPtr NativeFieldInfoPtr__multiplicationDelegate;

		// Token: 0x04002909 RID: 10505
		private static readonly IntPtr NativeFieldInfoPtr__divisionDelegate;

		// Token: 0x0400290A RID: 10506
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0;

		// Token: 0x0400290B RID: 10507
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0;

		// Token: 0x0400290C RID: 10508
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0;

		// Token: 0x0400290D RID: 10509
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Float3x_0;

		// Token: 0x0400290E RID: 10510
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Static_Float3x_Float3x_0;

		// Token: 0x0400290F RID: 10511
		private static readonly IntPtr NativeMethodInfoPtr_get_Zero_Public_Static_get_Float3x_0;

		// Token: 0x04002910 RID: 10512
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002911 RID: 10513
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002912 RID: 10514
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Float3x_0;

		// Token: 0x04002913 RID: 10515
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002914 RID: 10516
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Static_Float3x_Float3x_Float3x_0;

		// Token: 0x04002915 RID: 10517
		private static readonly IntPtr NativeMethodInfoPtr_Subtract_Public_Static_Float3x_Float3x_Float3x_0;

		// Token: 0x04002916 RID: 10518
		private static readonly IntPtr NativeMethodInfoPtr_Multiply_Public_Static_Float3x_Float3x_Float3x_0;

		// Token: 0x04002917 RID: 10519
		private static readonly IntPtr NativeMethodInfoPtr_Divide_Public_Static_Float3x_Float3x_Float3x_0;

		// Token: 0x04002918 RID: 10520
		private static readonly IntPtr NativeMethodInfoPtr_GetAdditionDelegate_Public_Static_Func_3_Float3x_Float3x_Float3x_0;

		// Token: 0x04002919 RID: 10521
		private static readonly IntPtr NativeMethodInfoPtr_GetSubtractionDelegate_Public_Static_Func_3_Float3x_Float3x_Float3x_0;

		// Token: 0x0400291A RID: 10522
		private static readonly IntPtr NativeMethodInfoPtr_GetMultiplicationDelegate_Public_Static_Func_3_Float3x_Float3x_Float3x_0;

		// Token: 0x0400291B RID: 10523
		private static readonly IntPtr NativeMethodInfoPtr_GetDivisionDelegate_Public_Static_Func_3_Float3x_Float3x_Float3x_0;

		// Token: 0x0400291C RID: 10524
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Float3x_Vector3_0;

		// Token: 0x0400291D RID: 10525
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_Float3x_0;

		// Token: 0x0400291E RID: 10526
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Float3x_Float3x_Float3x_0;

		// Token: 0x0400291F RID: 10527
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Float3x_Float3x_Float3x_0;

		// Token: 0x04002920 RID: 10528
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Float3x_Float3x_Float3x_0;

		// Token: 0x04002921 RID: 10529
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_Float3x_Float3x_Float3x_0;

		// Token: 0x04002922 RID: 10530
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Float3x_Float3x_Single_0;

		// Token: 0x04002923 RID: 10531
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Float3x_Float3x_Single_0;

		// Token: 0x04002924 RID: 10532
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Float3x_Float3x_Single_0;

		// Token: 0x04002925 RID: 10533
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_Float3x_Float3x_Single_0;

		// Token: 0x04002926 RID: 10534
		[FieldOffset(0)]
		public float a;

		// Token: 0x04002927 RID: 10535
		[FieldOffset(4)]
		public float b;

		// Token: 0x04002928 RID: 10536
		[FieldOffset(8)]
		public float c;
	}
}
