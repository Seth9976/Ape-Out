using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200026D RID: 621
	public sealed class AutoResetEvent : EventWaitHandle
	{
		// Token: 0x06002B3E RID: 11070 RVA: 0x0000EEDC File Offset: 0x0000D0DC
		// Note: this type is marked as 'beforefieldinit'.
		static AutoResetEvent()
		{
			Il2CppClassPointerStore<AutoResetEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "AutoResetEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AutoResetEvent>.NativeClassPtr);
			AutoResetEvent.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoResetEvent>.NativeClassPtr, 100670233);
		}

		// Token: 0x06002B3F RID: 11071 RVA: 0x000E10FC File Offset: 0x000DF2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201016, XrefRangeEnd = 201017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AutoResetEvent(bool initialState)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AutoResetEvent>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoResetEvent.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B40 RID: 11072 RVA: 0x0000EF15 File Offset: 0x0000D115
		public AutoResetEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040025DF RID: 9695
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;
	}
}
