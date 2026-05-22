using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200034F RID: 847
	public class ValueTypeFixupInfo : Object
	{
		// Token: 0x06003750 RID: 14160 RVA: 0x0010E6CC File Offset: 0x0010C8CC
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeFixupInfo()
		{
			Il2CppClassPointerStore<ValueTypeFixupInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "ValueTypeFixupInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueTypeFixupInfo>.NativeClassPtr);
			ValueTypeFixupInfo.NativeFieldInfoPtr_m_containerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTypeFixupInfo>.NativeClassPtr, "m_containerID");
			ValueTypeFixupInfo.NativeFieldInfoPtr_m_parentField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTypeFixupInfo>.NativeClassPtr, "m_parentField");
			ValueTypeFixupInfo.NativeFieldInfoPtr_m_parentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTypeFixupInfo>.NativeClassPtr, "m_parentIndex");
			ValueTypeFixupInfo.NativeMethodInfoPtr__ctor_Public_Void_Int64_FieldInfo_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTypeFixupInfo>.NativeClassPtr, 100671864);
			ValueTypeFixupInfo.NativeMethodInfoPtr_get_ContainerID_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTypeFixupInfo>.NativeClassPtr, 100671865);
			ValueTypeFixupInfo.NativeMethodInfoPtr_get_ParentField_Public_get_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTypeFixupInfo>.NativeClassPtr, 100671866);
			ValueTypeFixupInfo.NativeMethodInfoPtr_get_ParentIndex_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTypeFixupInfo>.NativeClassPtr, 100671867);
		}

		// Token: 0x06003751 RID: 14161 RVA: 0x0010E788 File Offset: 0x0010C988
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 215675, RefRangeEnd = 215678, XrefRangeStart = 215673, XrefRangeEnd = 215675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTypeFixupInfo(long containerID, FieldInfo member, Il2CppStructArray<int> parentIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueTypeFixupInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref containerID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentIndex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTypeFixupInfo.NativeMethodInfoPtr__ctor_Public_Void_Int64_FieldInfo_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D60 RID: 3424
		// (get) Token: 0x06003752 RID: 14162 RVA: 0x0010E7F4 File Offset: 0x0010C9F4
		public unsafe long ContainerID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTypeFixupInfo.NativeMethodInfoPtr_get_ContainerID_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D61 RID: 3425
		// (get) Token: 0x06003753 RID: 14163 RVA: 0x0010E830 File Offset: 0x0010CA30
		public unsafe FieldInfo ParentField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTypeFixupInfo.NativeMethodInfoPtr_get_ParentField_Public_get_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000D62 RID: 3426
		// (get) Token: 0x06003754 RID: 14164 RVA: 0x0010E870 File Offset: 0x0010CA70
		public unsafe Il2CppStructArray<int> ParentIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTypeFixupInfo.NativeMethodInfoPtr_get_ParentIndex_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06003755 RID: 14165 RVA: 0x00013B1A File Offset: 0x00011D1A
		public ValueTypeFixupInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D5D RID: 3421
		// (get) Token: 0x06003756 RID: 14166 RVA: 0x0010E8B0 File Offset: 0x0010CAB0
		// (set) Token: 0x06003757 RID: 14167 RVA: 0x00013B23 File Offset: 0x00011D23
		public unsafe long m_containerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTypeFixupInfo.NativeFieldInfoPtr_m_containerID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTypeFixupInfo.NativeFieldInfoPtr_m_containerID)) = value;
			}
		}

		// Token: 0x17000D5E RID: 3422
		// (get) Token: 0x06003758 RID: 14168 RVA: 0x0010E8D8 File Offset: 0x0010CAD8
		// (set) Token: 0x06003759 RID: 14169 RVA: 0x00013B3E File Offset: 0x00011D3E
		public unsafe FieldInfo m_parentField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTypeFixupInfo.NativeFieldInfoPtr_m_parentField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTypeFixupInfo.NativeFieldInfoPtr_m_parentField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D5F RID: 3423
		// (get) Token: 0x0600375A RID: 14170 RVA: 0x0010E908 File Offset: 0x0010CB08
		// (set) Token: 0x0600375B RID: 14171 RVA: 0x00013B5D File Offset: 0x00011D5D
		public unsafe Il2CppStructArray<int> m_parentIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTypeFixupInfo.NativeFieldInfoPtr_m_parentIndex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTypeFixupInfo.NativeFieldInfoPtr_m_parentIndex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002E8D RID: 11917
		private static readonly IntPtr NativeFieldInfoPtr_m_containerID;

		// Token: 0x04002E8E RID: 11918
		private static readonly IntPtr NativeFieldInfoPtr_m_parentField;

		// Token: 0x04002E8F RID: 11919
		private static readonly IntPtr NativeFieldInfoPtr_m_parentIndex;

		// Token: 0x04002E90 RID: 11920
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_FieldInfo_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002E91 RID: 11921
		private static readonly IntPtr NativeMethodInfoPtr_get_ContainerID_Public_get_Int64_0;

		// Token: 0x04002E92 RID: 11922
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentField_Public_get_FieldInfo_0;

		// Token: 0x04002E93 RID: 11923
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentIndex_Public_get_Il2CppStructArray_1_Int32_0;
	}
}
