using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSanford.Multimedia.Timers
{
	// Token: 0x0200018D RID: 397
	public class TimerStartException : ApplicationException
	{
		// Token: 0x0600121C RID: 4636 RVA: 0x000076E3 File Offset: 0x000058E3
		// Note: this type is marked as 'beforefieldinit'.
		static TimerStartException()
		{
			Il2CppClassPointerStore<TimerStartException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Timers", "TimerStartException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimerStartException>.NativeClassPtr);
			TimerStartException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerStartException>.NativeClassPtr, 100665914);
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x00056944 File Offset: 0x00054B44
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 14773, RefRangeEnd = 14779, XrefRangeStart = 14772, XrefRangeEnd = 14773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimerStartException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimerStartException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerStartException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x0000771C File Offset: 0x0000591C
		public TimerStartException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400142B RID: 5163
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
