using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppRewired.Utils.Classes.Data
{
	// Token: 0x020001C2 RID: 450
	[Serializable]
	public class IntVector3 : global::Il2CppSystem.Object
	{
		// Token: 0x06002F4F RID: 12111 RVA: 0x000EB8A8 File Offset: 0x000E9AA8
		// Note: this type is marked as 'beforefieldinit'.
		static IntVector3()
		{
			Il2CppClassPointerStore<IntVector3>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Classes.Data", "IntVector3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntVector3>.NativeClassPtr);
			IntVector3.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntVector3>.NativeClassPtr, "x");
			IntVector3.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntVector3>.NativeClassPtr, "y");
			IntVector3.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntVector3>.NativeClassPtr, "z");
			IntVector3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector3>.NativeClassPtr, 100675460);
			IntVector3.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector3>.NativeClassPtr, 100675461);
			IntVector3.NativeMethodInfoPtr_Clone_Public_IntVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector3>.NativeClassPtr, 100675462);
			IntVector3.NativeMethodInfoPtr_op_Addition_Public_Static_IntVector3_IntVector3_IntVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector3>.NativeClassPtr, 100675463);
			IntVector3.NativeMethodInfoPtr_op_Subtraction_Public_Static_IntVector3_IntVector3_IntVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector3>.NativeClassPtr, 100675464);
			IntVector3.NativeMethodInfoPtr_op_Multiply_Public_Static_IntVector3_IntVector3_IntVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector3>.NativeClassPtr, 100675465);
			IntVector3.NativeMethodInfoPtr_op_Division_Public_Static_IntVector3_IntVector3_IntVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector3>.NativeClassPtr, 100675466);
			IntVector3.NativeMethodInfoPtr_op_Addition_Public_Static_IntVector3_IntVector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector3>.NativeClassPtr, 100675467);
			IntVector3.NativeMethodInfoPtr_op_Subtraction_Public_Static_IntVector3_IntVector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector3>.NativeClassPtr, 100675468);
			IntVector3.NativeMethodInfoPtr_op_Multiply_Public_Static_IntVector3_IntVector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector3>.NativeClassPtr, 100675469);
			IntVector3.NativeMethodInfoPtr_op_Division_Public_Static_IntVector3_IntVector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector3>.NativeClassPtr, 100675470);
			IntVector3.NativeMethodInfoPtr_op_Addition_Public_Static_Vector3_IntVector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector3>.NativeClassPtr, 100675471);
			IntVector3.NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector3_IntVector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector3>.NativeClassPtr, 100675472);
			IntVector3.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3_IntVector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector3>.NativeClassPtr, 100675473);
			IntVector3.NativeMethodInfoPtr_op_Division_Public_Static_Vector3_IntVector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector3>.NativeClassPtr, 100675474);
		}

		// Token: 0x06002F50 RID: 12112 RVA: 0x000EBA40 File Offset: 0x000E9C40
		[CallerCount(0)]
		public unsafe IntVector3()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntVector3>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F51 RID: 12113 RVA: 0x000EBA7C File Offset: 0x000E9C7C
		[CallerCount(0)]
		public unsafe IntVector3(int inX, int inY, int inZ)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntVector3>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inX;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inY;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inZ;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector3.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F52 RID: 12114 RVA: 0x000EBAE0 File Offset: 0x000E9CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335008, XrefRangeEnd = 335011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntVector3 Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector3.NativeMethodInfoPtr_Clone_Public_IntVector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntVector3>(intPtr3) : null;
		}

		// Token: 0x06002F53 RID: 12115 RVA: 0x000EBB20 File Offset: 0x000E9D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335011, XrefRangeEnd = 335014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntVector3 operator +(IntVector3 value1, IntVector3 value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector3.NativeMethodInfoPtr_op_Addition_Public_Static_IntVector3_IntVector3_IntVector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntVector3>(intPtr3) : null;
		}

		// Token: 0x06002F54 RID: 12116 RVA: 0x000EBB78 File Offset: 0x000E9D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335014, XrefRangeEnd = 335017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntVector3 operator -(IntVector3 value1, IntVector3 value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector3.NativeMethodInfoPtr_op_Subtraction_Public_Static_IntVector3_IntVector3_IntVector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntVector3>(intPtr3) : null;
		}

		// Token: 0x06002F55 RID: 12117 RVA: 0x000EBBD0 File Offset: 0x000E9DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335017, XrefRangeEnd = 335020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntVector3 operator *(IntVector3 value1, IntVector3 value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector3.NativeMethodInfoPtr_op_Multiply_Public_Static_IntVector3_IntVector3_IntVector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntVector3>(intPtr3) : null;
		}

		// Token: 0x06002F56 RID: 12118 RVA: 0x000EBC28 File Offset: 0x000E9E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335020, XrefRangeEnd = 335023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntVector3 operator /(IntVector3 value1, IntVector3 value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector3.NativeMethodInfoPtr_op_Division_Public_Static_IntVector3_IntVector3_IntVector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntVector3>(intPtr3) : null;
		}

		// Token: 0x06002F57 RID: 12119 RVA: 0x000EBC80 File Offset: 0x000E9E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335023, XrefRangeEnd = 335026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntVector3 operator +(IntVector3 value1, int value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector3.NativeMethodInfoPtr_op_Addition_Public_Static_IntVector3_IntVector3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntVector3>(intPtr3) : null;
		}

		// Token: 0x06002F58 RID: 12120 RVA: 0x000EBCD4 File Offset: 0x000E9ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335026, XrefRangeEnd = 335029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntVector3 operator -(IntVector3 value1, int value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector3.NativeMethodInfoPtr_op_Subtraction_Public_Static_IntVector3_IntVector3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntVector3>(intPtr3) : null;
		}

		// Token: 0x06002F59 RID: 12121 RVA: 0x000EBD28 File Offset: 0x000E9F28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335029, XrefRangeEnd = 335032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntVector3 operator *(IntVector3 value1, int value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector3.NativeMethodInfoPtr_op_Multiply_Public_Static_IntVector3_IntVector3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntVector3>(intPtr3) : null;
		}

		// Token: 0x06002F5A RID: 12122 RVA: 0x000EBD7C File Offset: 0x000E9F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335032, XrefRangeEnd = 335035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntVector3 operator /(IntVector3 value1, int value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector3.NativeMethodInfoPtr_op_Division_Public_Static_IntVector3_IntVector3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntVector3>(intPtr3) : null;
		}

		// Token: 0x06002F5B RID: 12123 RVA: 0x000EBDD0 File Offset: 0x000E9FD0
		[CallerCount(0)]
		public unsafe static Vector3 operator +(IntVector3 value1, float value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector3.NativeMethodInfoPtr_op_Addition_Public_Static_Vector3_IntVector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F5C RID: 12124 RVA: 0x000EBE20 File Offset: 0x000EA020
		[CallerCount(0)]
		public unsafe static Vector3 operator -(IntVector3 value1, float value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector3.NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector3_IntVector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F5D RID: 12125 RVA: 0x000EBE70 File Offset: 0x000EA070
		[CallerCount(0)]
		public unsafe static Vector3 operator *(IntVector3 value1, float value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector3.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3_IntVector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F5E RID: 12126 RVA: 0x000EBEC0 File Offset: 0x000EA0C0
		[CallerCount(0)]
		public unsafe static Vector3 operator /(IntVector3 value1, float value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector3.NativeMethodInfoPtr_op_Division_Public_Static_Vector3_IntVector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F5F RID: 12127 RVA: 0x00011423 File Offset: 0x0000F623
		public IntVector3(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EDD RID: 3805
		// (get) Token: 0x06002F60 RID: 12128 RVA: 0x000EBF10 File Offset: 0x000EA110
		// (set) Token: 0x06002F61 RID: 12129 RVA: 0x0001142C File Offset: 0x0000F62C
		public unsafe int x
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntVector3.NativeFieldInfoPtr_x);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntVector3.NativeFieldInfoPtr_x)) = value;
			}
		}

		// Token: 0x17000EDE RID: 3806
		// (get) Token: 0x06002F62 RID: 12130 RVA: 0x000EBF38 File Offset: 0x000EA138
		// (set) Token: 0x06002F63 RID: 12131 RVA: 0x00011447 File Offset: 0x0000F647
		public unsafe int y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntVector3.NativeFieldInfoPtr_y);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntVector3.NativeFieldInfoPtr_y)) = value;
			}
		}

		// Token: 0x17000EDF RID: 3807
		// (get) Token: 0x06002F64 RID: 12132 RVA: 0x000EBF60 File Offset: 0x000EA160
		// (set) Token: 0x06002F65 RID: 12133 RVA: 0x00011462 File Offset: 0x0000F662
		public unsafe int z
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntVector3.NativeFieldInfoPtr_z);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntVector3.NativeFieldInfoPtr_z)) = value;
			}
		}

		// Token: 0x0400280F RID: 10255
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x04002810 RID: 10256
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04002811 RID: 10257
		private static readonly IntPtr NativeFieldInfoPtr_z;

		// Token: 0x04002812 RID: 10258
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002813 RID: 10259
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

		// Token: 0x04002814 RID: 10260
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_IntVector3_0;

		// Token: 0x04002815 RID: 10261
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_IntVector3_IntVector3_IntVector3_0;

		// Token: 0x04002816 RID: 10262
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_IntVector3_IntVector3_IntVector3_0;

		// Token: 0x04002817 RID: 10263
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_IntVector3_IntVector3_IntVector3_0;

		// Token: 0x04002818 RID: 10264
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_IntVector3_IntVector3_IntVector3_0;

		// Token: 0x04002819 RID: 10265
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_IntVector3_IntVector3_Int32_0;

		// Token: 0x0400281A RID: 10266
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_IntVector3_IntVector3_Int32_0;

		// Token: 0x0400281B RID: 10267
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_IntVector3_IntVector3_Int32_0;

		// Token: 0x0400281C RID: 10268
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_IntVector3_IntVector3_Int32_0;

		// Token: 0x0400281D RID: 10269
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Vector3_IntVector3_Single_0;

		// Token: 0x0400281E RID: 10270
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector3_IntVector3_Single_0;

		// Token: 0x0400281F RID: 10271
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3_IntVector3_Single_0;

		// Token: 0x04002820 RID: 10272
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_Vector3_IntVector3_Single_0;
	}
}
