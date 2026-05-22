using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001C7 RID: 455
	[Serializable]
	public sealed class CustomAttributeNamedArgument : ValueType
	{
		// Token: 0x06001D78 RID: 7544 RVA: 0x000A8FB0 File Offset: 0x000A71B0
		// Note: this type is marked as 'beforefieldinit'.
		static CustomAttributeNamedArgument()
		{
			Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "CustomAttributeNamedArgument");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr);
			CustomAttributeNamedArgument.NativeFieldInfoPtr_typedArgument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr, "typedArgument");
			CustomAttributeNamedArgument.NativeFieldInfoPtr_memberInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr, "memberInfo");
			CustomAttributeNamedArgument.NativeMethodInfoPtr__ctor_Public_Void_MemberInfo_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr, 100668268);
			CustomAttributeNamedArgument.NativeMethodInfoPtr_get_MemberInfo_Public_get_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr, 100668269);
			CustomAttributeNamedArgument.NativeMethodInfoPtr_get_TypedValue_Public_get_CustomAttributeTypedArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr, 100668270);
			CustomAttributeNamedArgument.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr, 100668271);
			CustomAttributeNamedArgument.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr, 100668272);
			CustomAttributeNamedArgument.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr, 100668273);
		}

		// Token: 0x06001D79 RID: 7545 RVA: 0x000A9080 File Offset: 0x000A7280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187680, XrefRangeEnd = 187682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomAttributeNamedArgument(MemberInfo memberInfo, Object value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeNamedArgument.NativeMethodInfoPtr__ctor_Public_Void_MemberInfo_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06001D7A RID: 7546 RVA: 0x000A90E4 File Offset: 0x000A72E4
		public unsafe MemberInfo MemberInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeNamedArgument.NativeMethodInfoPtr_get_MemberInfo_Public_get_MemberInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MemberInfo>(intPtr3) : null;
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06001D7B RID: 7547 RVA: 0x000A9128 File Offset: 0x000A7328
		public unsafe CustomAttributeTypedArgument TypedValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeNamedArgument.NativeMethodInfoPtr_get_TypedValue_Public_get_CustomAttributeTypedArgument_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new CustomAttributeTypedArgument(intPtr);
			}
		}

		// Token: 0x06001D7C RID: 7548 RVA: 0x000A9164 File Offset: 0x000A7364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187682, XrefRangeEnd = 187687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeNamedArgument.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001D7D RID: 7549 RVA: 0x000A91A0 File Offset: 0x000A73A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 187694, RefRangeEnd = 187695, XrefRangeStart = 187687, XrefRangeEnd = 187694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeNamedArgument.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D7E RID: 7550 RVA: 0x000A91F4 File Offset: 0x000A73F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187695, XrefRangeEnd = 187696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeNamedArgument.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D7F RID: 7551 RVA: 0x00009FE6 File Offset: 0x000081E6
		public CustomAttributeNamedArgument(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001D80 RID: 7552 RVA: 0x00009FEF File Offset: 0x000081EF
		public CustomAttributeNamedArgument()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr))
		{
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06001D81 RID: 7553 RVA: 0x000A9238 File Offset: 0x000A7438
		// (set) Token: 0x06001D82 RID: 7554 RVA: 0x0000A001 File Offset: 0x00008201
		public CustomAttributeTypedArgument typedArgument
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeNamedArgument.NativeFieldInfoPtr_typedArgument);
				return new CustomAttributeTypedArgument(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CustomAttributeTypedArgument>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeNamedArgument.NativeFieldInfoPtr_typedArgument), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CustomAttributeTypedArgument>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06001D83 RID: 7555 RVA: 0x000A9268 File Offset: 0x000A7468
		// (set) Token: 0x06001D84 RID: 7556 RVA: 0x0000A02F File Offset: 0x0000822F
		public unsafe MemberInfo memberInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeNamedArgument.NativeFieldInfoPtr_memberInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemberInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeNamedArgument.NativeFieldInfoPtr_memberInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B24 RID: 6948
		private static readonly IntPtr NativeFieldInfoPtr_typedArgument;

		// Token: 0x04001B25 RID: 6949
		private static readonly IntPtr NativeFieldInfoPtr_memberInfo;

		// Token: 0x04001B26 RID: 6950
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MemberInfo_Object_0;

		// Token: 0x04001B27 RID: 6951
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberInfo_Public_get_MemberInfo_0;

		// Token: 0x04001B28 RID: 6952
		private static readonly IntPtr NativeMethodInfoPtr_get_TypedValue_Public_get_CustomAttributeTypedArgument_0;

		// Token: 0x04001B29 RID: 6953
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001B2A RID: 6954
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001B2B RID: 6955
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
