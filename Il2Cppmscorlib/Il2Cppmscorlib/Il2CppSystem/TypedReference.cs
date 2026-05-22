using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;

namespace Il2CppSystem
{
	// Token: 0x020000F9 RID: 249
	[StructLayout(2)]
	public struct TypedReference
	{
		// Token: 0x0600124C RID: 4684 RVA: 0x000796C0 File Offset: 0x000778C0
		// Note: this type is marked as 'beforefieldinit'.
		static TypedReference()
		{
			Il2CppClassPointerStore<TypedReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TypedReference");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypedReference>.NativeClassPtr);
			TypedReference.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypedReference>.NativeClassPtr, "type");
			TypedReference.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypedReference>.NativeClassPtr, "Value");
			TypedReference.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypedReference>.NativeClassPtr, "Type");
			TypedReference.NativeMethodInfoPtr_MakeTypedReference_Public_Static_TypedReference_Object_Il2CppReferenceArray_1_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedReference>.NativeClassPtr, 100666539);
			TypedReference.NativeMethodInfoPtr_MakeTypedReferenceInternal_Private_Static_TypedReference_Object_Il2CppReferenceArray_1_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedReference>.NativeClassPtr, 100666540);
			TypedReference.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedReference>.NativeClassPtr, 100666541);
			TypedReference.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedReference>.NativeClassPtr, 100666542);
			TypedReference.NativeMethodInfoPtr_get_IsNull_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedReference>.NativeClassPtr, 100666543);
			TypedReference.NativeMethodInfoPtr_SetTypedReference_Public_Static_Void_TypedReference_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedReference>.NativeClassPtr, 100666544);
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x000797A4 File Offset: 0x000779A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 172687, RefRangeEnd = 172688, XrefRangeStart = 172669, XrefRangeEnd = 172687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypedReference MakeTypedReference(Object target, Il2CppReferenceArray<FieldInfo> flds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(flds);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedReference.NativeMethodInfoPtr_MakeTypedReference_Public_Static_TypedReference_Object_Il2CppReferenceArray_1_FieldInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x000797F8 File Offset: 0x000779F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172688, XrefRangeEnd = 172691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypedReference MakeTypedReferenceInternal(Object target, Il2CppReferenceArray<FieldInfo> fields)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fields);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedReference.NativeMethodInfoPtr_MakeTypedReferenceInternal_Private_Static_TypedReference_Object_Il2CppReferenceArray_1_FieldInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x0007984C File Offset: 0x00077A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172691, XrefRangeEnd = 172696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedReference.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x0007987C File Offset: 0x00077A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172696, XrefRangeEnd = 172703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedReference.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06001251 RID: 4689 RVA: 0x000798C0 File Offset: 0x00077AC0
		public unsafe bool IsNull
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedReference.NativeMethodInfoPtr_get_IsNull_Internal_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x000798F0 File Offset: 0x00077AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172703, XrefRangeEnd = 172709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetTypedReference(TypedReference target, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref target;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedReference.NativeMethodInfoPtr_SetTypedReference_Public_Static_Void_TypedReference_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x00006497 File Offset: 0x00004697
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TypedReference>.NativeClassPtr, ref this));
		}

		// Token: 0x04000FE9 RID: 4073
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04000FEA RID: 4074
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04000FEB RID: 4075
		private static readonly IntPtr NativeFieldInfoPtr_Type;

		// Token: 0x04000FEC RID: 4076
		private static readonly IntPtr NativeMethodInfoPtr_MakeTypedReference_Public_Static_TypedReference_Object_Il2CppReferenceArray_1_FieldInfo_0;

		// Token: 0x04000FED RID: 4077
		private static readonly IntPtr NativeMethodInfoPtr_MakeTypedReferenceInternal_Private_Static_TypedReference_Object_Il2CppReferenceArray_1_FieldInfo_0;

		// Token: 0x04000FEE RID: 4078
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000FEF RID: 4079
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000FF0 RID: 4080
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNull_Internal_get_Boolean_0;

		// Token: 0x04000FF1 RID: 4081
		private static readonly IntPtr NativeMethodInfoPtr_SetTypedReference_Public_Static_Void_TypedReference_Object_0;

		// Token: 0x04000FF2 RID: 4082
		[FieldOffset(0)]
		public RuntimeTypeHandle type;

		// Token: 0x04000FF3 RID: 4083
		[FieldOffset(8)]
		public IntPtr Value;

		// Token: 0x04000FF4 RID: 4084
		[FieldOffset(16)]
		public IntPtr Type;
	}
}
