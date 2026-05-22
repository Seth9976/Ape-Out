using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppRewired.Utils.Classes.Data
{
	// Token: 0x020001C5 RID: 453
	[Serializable]
	public class IntPadding : global::Il2CppSystem.Object
	{
		// Token: 0x06002F9D RID: 12189 RVA: 0x000ECE78 File Offset: 0x000EB078
		// Note: this type is marked as 'beforefieldinit'.
		static IntPadding()
		{
			Il2CppClassPointerStore<IntPadding>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Classes.Data", "IntPadding");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntPadding>.NativeClassPtr);
			IntPadding.NativeFieldInfoPtr_top = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntPadding>.NativeClassPtr, "top");
			IntPadding.NativeFieldInfoPtr_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntPadding>.NativeClassPtr, "right");
			IntPadding.NativeFieldInfoPtr_bottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntPadding>.NativeClassPtr, "bottom");
			IntPadding.NativeFieldInfoPtr_left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntPadding>.NativeClassPtr, "left");
			IntPadding.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPadding>.NativeClassPtr, 100675510);
			IntPadding.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPadding>.NativeClassPtr, 100675511);
			IntPadding.NativeMethodInfoPtr_Clone_Public_IntPadding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPadding>.NativeClassPtr, 100675512);
			IntPadding.NativeMethodInfoPtr_op_Addition_Public_Static_IntPadding_IntPadding_IntPadding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPadding>.NativeClassPtr, 100675513);
			IntPadding.NativeMethodInfoPtr_op_Subtraction_Public_Static_IntPadding_IntPadding_IntPadding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPadding>.NativeClassPtr, 100675514);
			IntPadding.NativeMethodInfoPtr_op_Multiply_Public_Static_IntPadding_IntPadding_IntPadding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPadding>.NativeClassPtr, 100675515);
			IntPadding.NativeMethodInfoPtr_op_Division_Public_Static_IntPadding_IntPadding_IntPadding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPadding>.NativeClassPtr, 100675516);
			IntPadding.NativeMethodInfoPtr_op_Addition_Public_Static_IntPadding_IntPadding_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPadding>.NativeClassPtr, 100675517);
			IntPadding.NativeMethodInfoPtr_op_Subtraction_Public_Static_IntPadding_IntPadding_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPadding>.NativeClassPtr, 100675518);
			IntPadding.NativeMethodInfoPtr_op_Multiply_Public_Static_IntPadding_IntPadding_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPadding>.NativeClassPtr, 100675519);
			IntPadding.NativeMethodInfoPtr_op_Division_Public_Static_IntPadding_IntPadding_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPadding>.NativeClassPtr, 100675520);
			IntPadding.NativeMethodInfoPtr_op_Addition_Public_Static_Vector4_IntPadding_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPadding>.NativeClassPtr, 100675521);
			IntPadding.NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector4_IntPadding_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPadding>.NativeClassPtr, 100675522);
			IntPadding.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector4_IntPadding_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPadding>.NativeClassPtr, 100675523);
			IntPadding.NativeMethodInfoPtr_op_Division_Public_Static_Vector4_IntPadding_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPadding>.NativeClassPtr, 100675524);
		}

		// Token: 0x06002F9E RID: 12190 RVA: 0x000ED024 File Offset: 0x000EB224
		[CallerCount(0)]
		public unsafe IntPadding()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntPadding>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPadding.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F9F RID: 12191 RVA: 0x000ED060 File Offset: 0x000EB260
		[CallerCount(0)]
		public unsafe IntPadding(int inTop, int inRight, int inBottom, int inLeft)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntPadding>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inTop;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inRight;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inBottom;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inLeft;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPadding.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FA0 RID: 12192 RVA: 0x000ED0D4 File Offset: 0x000EB2D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335068, XrefRangeEnd = 335071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPadding Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPadding.NativeMethodInfoPtr_Clone_Public_IntPadding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntPadding>(intPtr3) : null;
		}

		// Token: 0x06002FA1 RID: 12193 RVA: 0x000ED114 File Offset: 0x000EB314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335071, XrefRangeEnd = 335074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPadding operator +(IntPadding value1, IntPadding value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPadding.NativeMethodInfoPtr_op_Addition_Public_Static_IntPadding_IntPadding_IntPadding_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntPadding>(intPtr3) : null;
		}

		// Token: 0x06002FA2 RID: 12194 RVA: 0x000ED16C File Offset: 0x000EB36C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335074, XrefRangeEnd = 335077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPadding operator -(IntPadding value1, IntPadding value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPadding.NativeMethodInfoPtr_op_Subtraction_Public_Static_IntPadding_IntPadding_IntPadding_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntPadding>(intPtr3) : null;
		}

		// Token: 0x06002FA3 RID: 12195 RVA: 0x000ED1C4 File Offset: 0x000EB3C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335077, XrefRangeEnd = 335080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPadding operator *(IntPadding value1, IntPadding value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPadding.NativeMethodInfoPtr_op_Multiply_Public_Static_IntPadding_IntPadding_IntPadding_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntPadding>(intPtr3) : null;
		}

		// Token: 0x06002FA4 RID: 12196 RVA: 0x000ED21C File Offset: 0x000EB41C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335080, XrefRangeEnd = 335083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPadding operator /(IntPadding value1, IntPadding value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPadding.NativeMethodInfoPtr_op_Division_Public_Static_IntPadding_IntPadding_IntPadding_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntPadding>(intPtr3) : null;
		}

		// Token: 0x06002FA5 RID: 12197 RVA: 0x000ED274 File Offset: 0x000EB474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335083, XrefRangeEnd = 335086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPadding operator +(IntPadding value1, int value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPadding.NativeMethodInfoPtr_op_Addition_Public_Static_IntPadding_IntPadding_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntPadding>(intPtr3) : null;
		}

		// Token: 0x06002FA6 RID: 12198 RVA: 0x000ED2C8 File Offset: 0x000EB4C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335086, XrefRangeEnd = 335089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPadding operator -(IntPadding value1, int value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPadding.NativeMethodInfoPtr_op_Subtraction_Public_Static_IntPadding_IntPadding_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntPadding>(intPtr3) : null;
		}

		// Token: 0x06002FA7 RID: 12199 RVA: 0x000ED31C File Offset: 0x000EB51C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335089, XrefRangeEnd = 335092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPadding operator *(IntPadding value1, int value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPadding.NativeMethodInfoPtr_op_Multiply_Public_Static_IntPadding_IntPadding_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntPadding>(intPtr3) : null;
		}

		// Token: 0x06002FA8 RID: 12200 RVA: 0x000ED370 File Offset: 0x000EB570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335092, XrefRangeEnd = 335095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPadding operator /(IntPadding value1, int value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPadding.NativeMethodInfoPtr_op_Division_Public_Static_IntPadding_IntPadding_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntPadding>(intPtr3) : null;
		}

		// Token: 0x06002FA9 RID: 12201 RVA: 0x000ED3C4 File Offset: 0x000EB5C4
		[CallerCount(0)]
		public unsafe static Vector4 operator +(IntPadding value1, float value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPadding.NativeMethodInfoPtr_op_Addition_Public_Static_Vector4_IntPadding_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002FAA RID: 12202 RVA: 0x000ED414 File Offset: 0x000EB614
		[CallerCount(0)]
		public unsafe static Vector4 operator -(IntPadding value1, float value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPadding.NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector4_IntPadding_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002FAB RID: 12203 RVA: 0x000ED464 File Offset: 0x000EB664
		[CallerCount(0)]
		public unsafe static Vector4 operator *(IntPadding value1, float value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPadding.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector4_IntPadding_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002FAC RID: 12204 RVA: 0x000ED4B4 File Offset: 0x000EB6B4
		[CallerCount(0)]
		public unsafe static Vector4 operator /(IntPadding value1, float value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPadding.NativeMethodInfoPtr_op_Division_Public_Static_Vector4_IntPadding_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002FAD RID: 12205 RVA: 0x00011567 File Offset: 0x0000F767
		public IntPadding(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EF0 RID: 3824
		// (get) Token: 0x06002FAE RID: 12206 RVA: 0x000ED504 File Offset: 0x000EB704
		// (set) Token: 0x06002FAF RID: 12207 RVA: 0x00011570 File Offset: 0x0000F770
		public unsafe int top
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntPadding.NativeFieldInfoPtr_top);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntPadding.NativeFieldInfoPtr_top)) = value;
			}
		}

		// Token: 0x17000EF1 RID: 3825
		// (get) Token: 0x06002FB0 RID: 12208 RVA: 0x000ED52C File Offset: 0x000EB72C
		// (set) Token: 0x06002FB1 RID: 12209 RVA: 0x0001158B File Offset: 0x0000F78B
		public unsafe int right
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntPadding.NativeFieldInfoPtr_right);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntPadding.NativeFieldInfoPtr_right)) = value;
			}
		}

		// Token: 0x17000EF2 RID: 3826
		// (get) Token: 0x06002FB2 RID: 12210 RVA: 0x000ED554 File Offset: 0x000EB754
		// (set) Token: 0x06002FB3 RID: 12211 RVA: 0x000115A6 File Offset: 0x0000F7A6
		public unsafe int bottom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntPadding.NativeFieldInfoPtr_bottom);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntPadding.NativeFieldInfoPtr_bottom)) = value;
			}
		}

		// Token: 0x17000EF3 RID: 3827
		// (get) Token: 0x06002FB4 RID: 12212 RVA: 0x000ED57C File Offset: 0x000EB77C
		// (set) Token: 0x06002FB5 RID: 12213 RVA: 0x000115C1 File Offset: 0x0000F7C1
		public unsafe int left
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntPadding.NativeFieldInfoPtr_left);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntPadding.NativeFieldInfoPtr_left)) = value;
			}
		}

		// Token: 0x0400284C RID: 10316
		private static readonly IntPtr NativeFieldInfoPtr_top;

		// Token: 0x0400284D RID: 10317
		private static readonly IntPtr NativeFieldInfoPtr_right;

		// Token: 0x0400284E RID: 10318
		private static readonly IntPtr NativeFieldInfoPtr_bottom;

		// Token: 0x0400284F RID: 10319
		private static readonly IntPtr NativeFieldInfoPtr_left;

		// Token: 0x04002850 RID: 10320
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002851 RID: 10321
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0;

		// Token: 0x04002852 RID: 10322
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_IntPadding_0;

		// Token: 0x04002853 RID: 10323
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_IntPadding_IntPadding_IntPadding_0;

		// Token: 0x04002854 RID: 10324
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_IntPadding_IntPadding_IntPadding_0;

		// Token: 0x04002855 RID: 10325
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_IntPadding_IntPadding_IntPadding_0;

		// Token: 0x04002856 RID: 10326
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_IntPadding_IntPadding_IntPadding_0;

		// Token: 0x04002857 RID: 10327
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_IntPadding_IntPadding_Int32_0;

		// Token: 0x04002858 RID: 10328
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_IntPadding_IntPadding_Int32_0;

		// Token: 0x04002859 RID: 10329
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_IntPadding_IntPadding_Int32_0;

		// Token: 0x0400285A RID: 10330
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_IntPadding_IntPadding_Int32_0;

		// Token: 0x0400285B RID: 10331
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Vector4_IntPadding_Single_0;

		// Token: 0x0400285C RID: 10332
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector4_IntPadding_Single_0;

		// Token: 0x0400285D RID: 10333
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Vector4_IntPadding_Single_0;

		// Token: 0x0400285E RID: 10334
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_Vector4_IntPadding_Single_0;
	}
}
