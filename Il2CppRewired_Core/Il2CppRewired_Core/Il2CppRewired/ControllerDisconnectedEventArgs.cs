using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x0200010F RID: 271
	public class ControllerDisconnectedEventArgs : EventArgs
	{
		// Token: 0x06001A2E RID: 6702 RVA: 0x00092EEC File Offset: 0x000910EC
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerDisconnectedEventArgs()
		{
			Il2CppClassPointerStore<ControllerDisconnectedEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "ControllerDisconnectedEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerDisconnectedEventArgs>.NativeClassPtr);
			ControllerDisconnectedEventArgs.NativeFieldInfoPtr_rewiredId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerDisconnectedEventArgs>.NativeClassPtr, "rewiredId");
			ControllerDisconnectedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerDisconnectedEventArgs>.NativeClassPtr, 100669487);
		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x00092F44 File Offset: 0x00091144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279049, XrefRangeEnd = 279052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerDisconnectedEventArgs(int rewiredId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerDisconnectedEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rewiredId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerDisconnectedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A30 RID: 6704 RVA: 0x0000AB44 File Offset: 0x00008D44
		public ControllerDisconnectedEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06001A31 RID: 6705 RVA: 0x00092F8C File Offset: 0x0009118C
		// (set) Token: 0x06001A32 RID: 6706 RVA: 0x0000AB4D File Offset: 0x00008D4D
		public unsafe int rewiredId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerDisconnectedEventArgs.NativeFieldInfoPtr_rewiredId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerDisconnectedEventArgs.NativeFieldInfoPtr_rewiredId)) = value;
			}
		}

		// Token: 0x04001686 RID: 5766
		private static readonly IntPtr NativeFieldInfoPtr_rewiredId;

		// Token: 0x04001687 RID: 5767
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
	}
}
