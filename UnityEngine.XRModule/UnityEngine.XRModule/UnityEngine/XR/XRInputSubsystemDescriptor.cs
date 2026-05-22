using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.XR
{
	// Token: 0x02000013 RID: 19
	public class XRInputSubsystemDescriptor : IntegratedSubsystemDescriptor<XRInputSubsystem>
	{
		// Token: 0x06000120 RID: 288 RVA: 0x00005034 File Offset: 0x00003234
		// Note: this type is marked as 'beforefieldinit'.
		static XRInputSubsystemDescriptor()
		{
			Il2CppClassPointerStore<XRInputSubsystemDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.XRModule.dll", "UnityEngine.XR", "XRInputSubsystemDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRInputSubsystemDescriptor>.NativeClassPtr);
			XRInputSubsystemDescriptor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRInputSubsystemDescriptor>.NativeClassPtr, 100663336);
			XRInputSubsystemDescriptor.get_disablesLegacyInputDelegateField = IL2CPP.ResolveICall<XRInputSubsystemDescriptor.get_disablesLegacyInputDelegate>("UnityEngine.XR.XRInputSubsystemDescriptor::get_disablesLegacyInput");
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00005088 File Offset: 0x00003288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535116, XrefRangeEnd = 535117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XRInputSubsystemDescriptor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XRInputSubsystemDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRInputSubsystemDescriptor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002B3B File Offset: 0x00000D3B
		public XRInputSubsystemDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00002B44 File Offset: 0x00000D44
		public bool disablesLegacyInput
		{
			get
			{
				return XRInputSubsystemDescriptor.get_disablesLegacyInputDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000D7 RID: 215
		private static readonly XRInputSubsystemDescriptor.get_disablesLegacyInputDelegate get_disablesLegacyInputDelegateField;

		// Token: 0x02000089 RID: 137
		// (Invoke) Token: 0x0600021B RID: 539
		private delegate bool get_disablesLegacyInputDelegate(IntPtr @this);
	}
}
