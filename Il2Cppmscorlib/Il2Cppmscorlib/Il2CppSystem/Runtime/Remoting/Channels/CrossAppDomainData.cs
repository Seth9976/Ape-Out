using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Channels
{
	// Token: 0x020003C4 RID: 964
	[Serializable]
	public class CrossAppDomainData : Object
	{
		// Token: 0x06003F0C RID: 16140 RVA: 0x00128E94 File Offset: 0x00127094
		// Note: this type is marked as 'beforefieldinit'.
		static CrossAppDomainData()
		{
			Il2CppClassPointerStore<CrossAppDomainData>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Channels", "CrossAppDomainData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrossAppDomainData>.NativeClassPtr);
			CrossAppDomainData.NativeFieldInfoPtr__ContextID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrossAppDomainData>.NativeClassPtr, "_ContextID");
			CrossAppDomainData.NativeFieldInfoPtr__DomainID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrossAppDomainData>.NativeClassPtr, "_DomainID");
			CrossAppDomainData.NativeFieldInfoPtr__processGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrossAppDomainData>.NativeClassPtr, "_processGuid");
			CrossAppDomainData.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainData>.NativeClassPtr, 100672624);
			CrossAppDomainData.NativeMethodInfoPtr_get_DomainID_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainData>.NativeClassPtr, 100672625);
			CrossAppDomainData.NativeMethodInfoPtr_get_ProcessID_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainData>.NativeClassPtr, 100672626);
		}

		// Token: 0x06003F0D RID: 16141 RVA: 0x00128F3C File Offset: 0x0012713C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 223128, RefRangeEnd = 223130, XrefRangeStart = 223121, XrefRangeEnd = 223128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CrossAppDomainData(int domainId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrossAppDomainData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref domainId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossAppDomainData.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000FC6 RID: 4038
		// (get) Token: 0x06003F0E RID: 16142 RVA: 0x00128F84 File Offset: 0x00127184
		public unsafe int DomainID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossAppDomainData.NativeMethodInfoPtr_get_DomainID_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000FC7 RID: 4039
		// (get) Token: 0x06003F0F RID: 16143 RVA: 0x00128FC0 File Offset: 0x001271C0
		public unsafe string ProcessID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossAppDomainData.NativeMethodInfoPtr_get_ProcessID_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003F10 RID: 16144 RVA: 0x000178B7 File Offset: 0x00015AB7
		public CrossAppDomainData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FC3 RID: 4035
		// (get) Token: 0x06003F11 RID: 16145 RVA: 0x00128FF8 File Offset: 0x001271F8
		// (set) Token: 0x06003F12 RID: 16146 RVA: 0x000178C0 File Offset: 0x00015AC0
		public unsafe Object _ContextID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossAppDomainData.NativeFieldInfoPtr__ContextID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossAppDomainData.NativeFieldInfoPtr__ContextID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FC4 RID: 4036
		// (get) Token: 0x06003F13 RID: 16147 RVA: 0x00129028 File Offset: 0x00127228
		// (set) Token: 0x06003F14 RID: 16148 RVA: 0x000178DF File Offset: 0x00015ADF
		public unsafe int _DomainID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossAppDomainData.NativeFieldInfoPtr__DomainID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossAppDomainData.NativeFieldInfoPtr__DomainID)) = value;
			}
		}

		// Token: 0x17000FC5 RID: 4037
		// (get) Token: 0x06003F15 RID: 16149 RVA: 0x00129050 File Offset: 0x00127250
		// (set) Token: 0x06003F16 RID: 16150 RVA: 0x000178FA File Offset: 0x00015AFA
		public unsafe string _processGuid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossAppDomainData.NativeFieldInfoPtr__processGuid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossAppDomainData.NativeFieldInfoPtr__processGuid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003402 RID: 13314
		private static readonly IntPtr NativeFieldInfoPtr__ContextID;

		// Token: 0x04003403 RID: 13315
		private static readonly IntPtr NativeFieldInfoPtr__DomainID;

		// Token: 0x04003404 RID: 13316
		private static readonly IntPtr NativeFieldInfoPtr__processGuid;

		// Token: 0x04003405 RID: 13317
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x04003406 RID: 13318
		private static readonly IntPtr NativeMethodInfoPtr_get_DomainID_Internal_get_Int32_0;

		// Token: 0x04003407 RID: 13319
		private static readonly IntPtr NativeMethodInfoPtr_get_ProcessID_Internal_get_String_0;
	}
}
