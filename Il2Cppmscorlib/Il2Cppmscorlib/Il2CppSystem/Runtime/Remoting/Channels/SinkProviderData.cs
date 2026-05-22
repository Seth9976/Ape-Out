using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Remoting.Channels
{
	// Token: 0x020003D0 RID: 976
	public class SinkProviderData : Object
	{
		// Token: 0x06003F56 RID: 16214 RVA: 0x00129DD4 File Offset: 0x00127FD4
		// Note: this type is marked as 'beforefieldinit'.
		static SinkProviderData()
		{
			Il2CppClassPointerStore<SinkProviderData>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Channels", "SinkProviderData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SinkProviderData>.NativeClassPtr);
			SinkProviderData.NativeFieldInfoPtr_sinkName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SinkProviderData>.NativeClassPtr, "sinkName");
			SinkProviderData.NativeFieldInfoPtr_children = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SinkProviderData>.NativeClassPtr, "children");
			SinkProviderData.NativeFieldInfoPtr_properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SinkProviderData>.NativeClassPtr, "properties");
			SinkProviderData.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SinkProviderData>.NativeClassPtr, 100672658);
			SinkProviderData.NativeMethodInfoPtr_get_Children_Public_get_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SinkProviderData>.NativeClassPtr, 100672659);
			SinkProviderData.NativeMethodInfoPtr_get_Properties_Public_get_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SinkProviderData>.NativeClassPtr, 100672660);
		}

		// Token: 0x06003F57 RID: 16215 RVA: 0x00129E7C File Offset: 0x0012807C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 223394, RefRangeEnd = 223396, XrefRangeStart = 223386, XrefRangeEnd = 223394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SinkProviderData(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SinkProviderData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SinkProviderData.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000FDB RID: 4059
		// (get) Token: 0x06003F58 RID: 16216 RVA: 0x00129EC8 File Offset: 0x001280C8
		public unsafe IList Children
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SinkProviderData.NativeMethodInfoPtr_get_Children_Public_get_IList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList>(intPtr3) : null;
			}
		}

		// Token: 0x17000FDC RID: 4060
		// (get) Token: 0x06003F59 RID: 16217 RVA: 0x00129F08 File Offset: 0x00128108
		public unsafe IDictionary Properties
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SinkProviderData.NativeMethodInfoPtr_get_Properties_Public_get_IDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr3) : null;
			}
		}

		// Token: 0x06003F5A RID: 16218 RVA: 0x00017AE2 File Offset: 0x00015CE2
		public SinkProviderData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FD8 RID: 4056
		// (get) Token: 0x06003F5B RID: 16219 RVA: 0x00129F48 File Offset: 0x00128148
		// (set) Token: 0x06003F5C RID: 16220 RVA: 0x00017AEB File Offset: 0x00015CEB
		public unsafe string sinkName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SinkProviderData.NativeFieldInfoPtr_sinkName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SinkProviderData.NativeFieldInfoPtr_sinkName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FD9 RID: 4057
		// (get) Token: 0x06003F5D RID: 16221 RVA: 0x00129F70 File Offset: 0x00128170
		// (set) Token: 0x06003F5E RID: 16222 RVA: 0x00017B0A File Offset: 0x00015D0A
		public unsafe ArrayList children
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SinkProviderData.NativeFieldInfoPtr_children);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SinkProviderData.NativeFieldInfoPtr_children), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FDA RID: 4058
		// (get) Token: 0x06003F5F RID: 16223 RVA: 0x00129FA0 File Offset: 0x001281A0
		// (set) Token: 0x06003F60 RID: 16224 RVA: 0x00017B29 File Offset: 0x00015D29
		public unsafe Hashtable properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SinkProviderData.NativeFieldInfoPtr_properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SinkProviderData.NativeFieldInfoPtr_properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400342B RID: 13355
		private static readonly IntPtr NativeFieldInfoPtr_sinkName;

		// Token: 0x0400342C RID: 13356
		private static readonly IntPtr NativeFieldInfoPtr_children;

		// Token: 0x0400342D RID: 13357
		private static readonly IntPtr NativeFieldInfoPtr_properties;

		// Token: 0x0400342E RID: 13358
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400342F RID: 13359
		private static readonly IntPtr NativeMethodInfoPtr_get_Children_Public_get_IList_0;

		// Token: 0x04003430 RID: 13360
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Public_get_IDictionary_0;
	}
}
