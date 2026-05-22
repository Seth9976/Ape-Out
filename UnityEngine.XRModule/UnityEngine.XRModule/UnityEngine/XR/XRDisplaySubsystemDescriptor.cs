using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.XR
{
	// Token: 0x02000011 RID: 17
	public class XRDisplaySubsystemDescriptor : IntegratedSubsystemDescriptor<XRDisplaySubsystem>
	{
		// Token: 0x06000104 RID: 260 RVA: 0x00004D54 File Offset: 0x00002F54
		// Note: this type is marked as 'beforefieldinit'.
		static XRDisplaySubsystemDescriptor()
		{
			Il2CppClassPointerStore<XRDisplaySubsystemDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.XRModule.dll", "UnityEngine.XR", "XRDisplaySubsystemDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRDisplaySubsystemDescriptor>.NativeClassPtr);
			XRDisplaySubsystemDescriptor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystemDescriptor>.NativeClassPtr, 100663332);
			XRDisplaySubsystemDescriptor.get_disablesLegacyVrDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystemDescriptor.get_disablesLegacyVrDelegate>("UnityEngine.XR.XRDisplaySubsystemDescriptor::get_disablesLegacyVr");
			XRDisplaySubsystemDescriptor.get_enableBackBufferMSAADelegateField = IL2CPP.ResolveICall<XRDisplaySubsystemDescriptor.get_enableBackBufferMSAADelegate>("UnityEngine.XR.XRDisplaySubsystemDescriptor::get_enableBackBufferMSAA");
			XRDisplaySubsystemDescriptor.GetAvailableMirrorBlitModeCountDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystemDescriptor.GetAvailableMirrorBlitModeCountDelegate>("UnityEngine.XR.XRDisplaySubsystemDescriptor::GetAvailableMirrorBlitModeCount");
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00004DC8 File Offset: 0x00002FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535096, XrefRangeEnd = 535097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XRDisplaySubsystemDescriptor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XRDisplaySubsystemDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRDisplaySubsystemDescriptor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000029E9 File Offset: 0x00000BE9
		public XRDisplaySubsystemDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000107 RID: 263 RVA: 0x000029F2 File Offset: 0x00000BF2
		public bool disablesLegacyVr
		{
			get
			{
				return XRDisplaySubsystemDescriptor.get_disablesLegacyVrDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00002A04 File Offset: 0x00000C04
		public bool enableBackBufferMSAA
		{
			get
			{
				return XRDisplaySubsystemDescriptor.get_enableBackBufferMSAADelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002A16 File Offset: 0x00000C16
		public int GetAvailableMirrorBlitModeCount()
		{
			return XRDisplaySubsystemDescriptor.GetAvailableMirrorBlitModeCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000C7 RID: 199
		private static readonly XRDisplaySubsystemDescriptor.get_disablesLegacyVrDelegate get_disablesLegacyVrDelegateField;

		// Token: 0x040000C8 RID: 200
		private static readonly XRDisplaySubsystemDescriptor.get_enableBackBufferMSAADelegate get_enableBackBufferMSAADelegateField;

		// Token: 0x040000C9 RID: 201
		private static readonly XRDisplaySubsystemDescriptor.GetAvailableMirrorBlitModeCountDelegate GetAvailableMirrorBlitModeCountDelegateField;

		// Token: 0x0200007F RID: 127
		// (Invoke) Token: 0x06000207 RID: 519
		private delegate bool get_disablesLegacyVrDelegate(IntPtr @this);

		// Token: 0x02000080 RID: 128
		// (Invoke) Token: 0x06000209 RID: 521
		private delegate bool get_enableBackBufferMSAADelegate(IntPtr @this);

		// Token: 0x02000081 RID: 129
		// (Invoke) Token: 0x0600020B RID: 523
		private delegate int GetAvailableMirrorBlitModeCountDelegate(IntPtr @this);
	}
}
