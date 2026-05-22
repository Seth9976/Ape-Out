using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000274 RID: 628
	public sealed class ManualResetEvent : EventWaitHandle
	{
		// Token: 0x06002B97 RID: 11159 RVA: 0x0000F0F2 File Offset: 0x0000D2F2
		// Note: this type is marked as 'beforefieldinit'.
		static ManualResetEvent()
		{
			Il2CppClassPointerStore<ManualResetEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "ManualResetEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManualResetEvent>.NativeClassPtr);
			ManualResetEvent.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEvent>.NativeClassPtr, 100670293);
		}

		// Token: 0x06002B98 RID: 11160 RVA: 0x000E2694 File Offset: 0x000E0894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201335, XrefRangeEnd = 201336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManualResetEvent(bool initialState)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManualResetEvent>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEvent.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B99 RID: 11161 RVA: 0x0000F12B File Offset: 0x0000D32B
		public ManualResetEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400261F RID: 9759
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;
	}
}
