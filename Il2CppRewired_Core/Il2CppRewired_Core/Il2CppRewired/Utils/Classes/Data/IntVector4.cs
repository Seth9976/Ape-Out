using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppRewired.Utils.Classes.Data
{
	// Token: 0x020001C3 RID: 451
	[Serializable]
	public class IntVector4 : global::Il2CppSystem.Object
	{
		// Token: 0x06002F66 RID: 12134 RVA: 0x000EBF88 File Offset: 0x000EA188
		// Note: this type is marked as 'beforefieldinit'.
		static IntVector4()
		{
			Il2CppClassPointerStore<IntVector4>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Classes.Data", "IntVector4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntVector4>.NativeClassPtr);
			IntVector4.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntVector4>.NativeClassPtr, "x");
			IntVector4.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntVector4>.NativeClassPtr, "y");
			IntVector4.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntVector4>.NativeClassPtr, "z");
			IntVector4.NativeFieldInfoPtr_q = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntVector4>.NativeClassPtr, "q");
			IntVector4.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector4>.NativeClassPtr, 100675475);
			IntVector4.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector4>.NativeClassPtr, 100675476);
			IntVector4.NativeMethodInfoPtr_Clone_Public_IntVector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector4>.NativeClassPtr, 100675477);
			IntVector4.NativeMethodInfoPtr_op_Addition_Public_Static_IntVector4_IntVector4_IntVector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector4>.NativeClassPtr, 100675478);
			IntVector4.NativeMethodInfoPtr_op_Subtraction_Public_Static_IntVector4_IntVector4_IntVector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector4>.NativeClassPtr, 100675479);
			IntVector4.NativeMethodInfoPtr_op_Multiply_Public_Static_IntVector4_IntVector4_IntVector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector4>.NativeClassPtr, 100675480);
			IntVector4.NativeMethodInfoPtr_op_Division_Public_Static_IntVector4_IntVector4_IntVector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector4>.NativeClassPtr, 100675481);
			IntVector4.NativeMethodInfoPtr_op_Addition_Public_Static_IntVector4_IntVector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector4>.NativeClassPtr, 100675482);
			IntVector4.NativeMethodInfoPtr_op_Subtraction_Public_Static_IntVector4_IntVector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector4>.NativeClassPtr, 100675483);
			IntVector4.NativeMethodInfoPtr_op_Multiply_Public_Static_IntVector4_IntVector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector4>.NativeClassPtr, 100675484);
			IntVector4.NativeMethodInfoPtr_op_Division_Public_Static_IntVector4_IntVector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector4>.NativeClassPtr, 100675485);
			IntVector4.NativeMethodInfoPtr_op_Addition_Public_Static_Vector4_IntVector4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector4>.NativeClassPtr, 100675486);
			IntVector4.NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector4_IntVector4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector4>.NativeClassPtr, 100675487);
			IntVector4.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector4_IntVector4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector4>.NativeClassPtr, 100675488);
			IntVector4.NativeMethodInfoPtr_op_Division_Public_Static_Vector4_IntVector4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector4>.NativeClassPtr, 100675489);
		}

		// Token: 0x06002F67 RID: 12135 RVA: 0x000EC134 File Offset: 0x000EA334
		[CallerCount(0)]
		public unsafe IntVector4()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntVector4>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector4.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F68 RID: 12136 RVA: 0x000EC170 File Offset: 0x000EA370
		[CallerCount(0)]
		public unsafe IntVector4(int inX, int inY, int inZ, int inQ)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntVector4>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inX;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inY;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inZ;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inQ;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector4.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F69 RID: 12137 RVA: 0x000EC1E4 File Offset: 0x000EA3E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335035, XrefRangeEnd = 335038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntVector4 Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector4.NativeMethodInfoPtr_Clone_Public_IntVector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntVector4>(intPtr3) : null;
		}

		// Token: 0x06002F6A RID: 12138 RVA: 0x000EC224 File Offset: 0x000EA424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335038, XrefRangeEnd = 335041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntVector4 operator +(IntVector4 value1, IntVector4 value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector4.NativeMethodInfoPtr_op_Addition_Public_Static_IntVector4_IntVector4_IntVector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntVector4>(intPtr3) : null;
		}

		// Token: 0x06002F6B RID: 12139 RVA: 0x000EC27C File Offset: 0x000EA47C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335041, XrefRangeEnd = 335044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntVector4 operator -(IntVector4 value1, IntVector4 value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector4.NativeMethodInfoPtr_op_Subtraction_Public_Static_IntVector4_IntVector4_IntVector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntVector4>(intPtr3) : null;
		}

		// Token: 0x06002F6C RID: 12140 RVA: 0x000EC2D4 File Offset: 0x000EA4D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335044, XrefRangeEnd = 335047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntVector4 operator *(IntVector4 value1, IntVector4 value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector4.NativeMethodInfoPtr_op_Multiply_Public_Static_IntVector4_IntVector4_IntVector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntVector4>(intPtr3) : null;
		}

		// Token: 0x06002F6D RID: 12141 RVA: 0x000EC32C File Offset: 0x000EA52C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335047, XrefRangeEnd = 335050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntVector4 operator /(IntVector4 value1, IntVector4 value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector4.NativeMethodInfoPtr_op_Division_Public_Static_IntVector4_IntVector4_IntVector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntVector4>(intPtr3) : null;
		}

		// Token: 0x06002F6E RID: 12142 RVA: 0x000EC384 File Offset: 0x000EA584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335050, XrefRangeEnd = 335053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntVector4 operator +(IntVector4 value1, int value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector4.NativeMethodInfoPtr_op_Addition_Public_Static_IntVector4_IntVector4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntVector4>(intPtr3) : null;
		}

		// Token: 0x06002F6F RID: 12143 RVA: 0x000EC3D8 File Offset: 0x000EA5D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335053, XrefRangeEnd = 335056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntVector4 operator -(IntVector4 value1, int value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector4.NativeMethodInfoPtr_op_Subtraction_Public_Static_IntVector4_IntVector4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntVector4>(intPtr3) : null;
		}

		// Token: 0x06002F70 RID: 12144 RVA: 0x000EC42C File Offset: 0x000EA62C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335056, XrefRangeEnd = 335059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntVector4 operator *(IntVector4 value1, int value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector4.NativeMethodInfoPtr_op_Multiply_Public_Static_IntVector4_IntVector4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntVector4>(intPtr3) : null;
		}

		// Token: 0x06002F71 RID: 12145 RVA: 0x000EC480 File Offset: 0x000EA680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335059, XrefRangeEnd = 335062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntVector4 operator /(IntVector4 value1, int value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector4.NativeMethodInfoPtr_op_Division_Public_Static_IntVector4_IntVector4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntVector4>(intPtr3) : null;
		}

		// Token: 0x06002F72 RID: 12146 RVA: 0x000EC4D4 File Offset: 0x000EA6D4
		[CallerCount(0)]
		public unsafe static Vector4 operator +(IntVector4 value1, float value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector4.NativeMethodInfoPtr_op_Addition_Public_Static_Vector4_IntVector4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F73 RID: 12147 RVA: 0x000EC524 File Offset: 0x000EA724
		[CallerCount(0)]
		public unsafe static Vector4 operator -(IntVector4 value1, float value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector4.NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector4_IntVector4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F74 RID: 12148 RVA: 0x000EC574 File Offset: 0x000EA774
		[CallerCount(0)]
		public unsafe static Vector4 operator *(IntVector4 value1, float value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector4.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector4_IntVector4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F75 RID: 12149 RVA: 0x000EC5C4 File Offset: 0x000EA7C4
		[CallerCount(0)]
		public unsafe static Vector4 operator /(IntVector4 value1, float value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector4.NativeMethodInfoPtr_op_Division_Public_Static_Vector4_IntVector4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F76 RID: 12150 RVA: 0x0001147D File Offset: 0x0000F67D
		public IntVector4(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EE0 RID: 3808
		// (get) Token: 0x06002F77 RID: 12151 RVA: 0x000EC614 File Offset: 0x000EA814
		// (set) Token: 0x06002F78 RID: 12152 RVA: 0x00011486 File Offset: 0x0000F686
		public unsafe int x
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntVector4.NativeFieldInfoPtr_x);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntVector4.NativeFieldInfoPtr_x)) = value;
			}
		}

		// Token: 0x17000EE1 RID: 3809
		// (get) Token: 0x06002F79 RID: 12153 RVA: 0x000EC63C File Offset: 0x000EA83C
		// (set) Token: 0x06002F7A RID: 12154 RVA: 0x000114A1 File Offset: 0x0000F6A1
		public unsafe int y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntVector4.NativeFieldInfoPtr_y);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntVector4.NativeFieldInfoPtr_y)) = value;
			}
		}

		// Token: 0x17000EE2 RID: 3810
		// (get) Token: 0x06002F7B RID: 12155 RVA: 0x000EC664 File Offset: 0x000EA864
		// (set) Token: 0x06002F7C RID: 12156 RVA: 0x000114BC File Offset: 0x0000F6BC
		public unsafe int z
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntVector4.NativeFieldInfoPtr_z);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntVector4.NativeFieldInfoPtr_z)) = value;
			}
		}

		// Token: 0x17000EE3 RID: 3811
		// (get) Token: 0x06002F7D RID: 12157 RVA: 0x000EC68C File Offset: 0x000EA88C
		// (set) Token: 0x06002F7E RID: 12158 RVA: 0x000114D7 File Offset: 0x0000F6D7
		public unsafe int q
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntVector4.NativeFieldInfoPtr_q);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntVector4.NativeFieldInfoPtr_q)) = value;
			}
		}

		// Token: 0x04002821 RID: 10273
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x04002822 RID: 10274
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04002823 RID: 10275
		private static readonly IntPtr NativeFieldInfoPtr_z;

		// Token: 0x04002824 RID: 10276
		private static readonly IntPtr NativeFieldInfoPtr_q;

		// Token: 0x04002825 RID: 10277
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002826 RID: 10278
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0;

		// Token: 0x04002827 RID: 10279
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_IntVector4_0;

		// Token: 0x04002828 RID: 10280
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_IntVector4_IntVector4_IntVector4_0;

		// Token: 0x04002829 RID: 10281
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_IntVector4_IntVector4_IntVector4_0;

		// Token: 0x0400282A RID: 10282
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_IntVector4_IntVector4_IntVector4_0;

		// Token: 0x0400282B RID: 10283
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_IntVector4_IntVector4_IntVector4_0;

		// Token: 0x0400282C RID: 10284
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_IntVector4_IntVector4_Int32_0;

		// Token: 0x0400282D RID: 10285
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_IntVector4_IntVector4_Int32_0;

		// Token: 0x0400282E RID: 10286
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_IntVector4_IntVector4_Int32_0;

		// Token: 0x0400282F RID: 10287
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_IntVector4_IntVector4_Int32_0;

		// Token: 0x04002830 RID: 10288
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Vector4_IntVector4_Single_0;

		// Token: 0x04002831 RID: 10289
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector4_IntVector4_Single_0;

		// Token: 0x04002832 RID: 10290
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Vector4_IntVector4_Single_0;

		// Token: 0x04002833 RID: 10291
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_Vector4_IntVector4_Single_0;
	}
}
