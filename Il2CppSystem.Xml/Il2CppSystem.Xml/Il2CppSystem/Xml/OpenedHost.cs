using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200009A RID: 154
	public class OpenedHost : Object
	{
		// Token: 0x06000FA5 RID: 4005 RVA: 0x00057B14 File Offset: 0x00055D14
		// Note: this type is marked as 'beforefieldinit'.
		static OpenedHost()
		{
			Il2CppClassPointerStore<OpenedHost>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "OpenedHost");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OpenedHost>.NativeClassPtr);
			OpenedHost.NativeFieldInfoPtr_nonCachedConnectionsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenedHost>.NativeClassPtr, "nonCachedConnectionsCount");
			OpenedHost.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpenedHost>.NativeClassPtr, 100665810);
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x00057B6C File Offset: 0x00055D6C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OpenedHost()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OpenedHost>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpenedHost.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x0000730E File Offset: 0x0000550E
		public OpenedHost(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06000FA8 RID: 4008 RVA: 0x00057BA8 File Offset: 0x00055DA8
		// (set) Token: 0x06000FA9 RID: 4009 RVA: 0x00007317 File Offset: 0x00005517
		public unsafe int nonCachedConnectionsCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpenedHost.NativeFieldInfoPtr_nonCachedConnectionsCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpenedHost.NativeFieldInfoPtr_nonCachedConnectionsCount)) = value;
			}
		}

		// Token: 0x04000C48 RID: 3144
		private static readonly IntPtr NativeFieldInfoPtr_nonCachedConnectionsCount;

		// Token: 0x04000C49 RID: 3145
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
