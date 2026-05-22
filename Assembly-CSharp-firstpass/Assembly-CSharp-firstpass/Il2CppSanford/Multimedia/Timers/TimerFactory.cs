using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSanford.Multimedia.Timers
{
	// Token: 0x0200018E RID: 398
	public static class TimerFactory : Object
	{
		// Token: 0x0600121F RID: 4639 RVA: 0x00056990 File Offset: 0x00054B90
		// Note: this type is marked as 'beforefieldinit'.
		static TimerFactory()
		{
			Il2CppClassPointerStore<TimerFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Timers", "TimerFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimerFactory>.NativeClassPtr);
			TimerFactory.NativeMethodInfoPtr_IsRunningOnMono_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerFactory>.NativeClassPtr, 100665915);
			TimerFactory.NativeMethodInfoPtr_Create_Public_Static_ITimer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerFactory>.NativeClassPtr, 100665916);
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x000569E8 File Offset: 0x00054BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14779, XrefRangeEnd = 14788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsRunningOnMono()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerFactory.NativeMethodInfoPtr_IsRunningOnMono_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001221 RID: 4641 RVA: 0x00056A18 File Offset: 0x00054C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14788, XrefRangeEnd = 14802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ITimer Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerFactory.NativeMethodInfoPtr_Create_Public_Static_ITimer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ITimer>(intPtr3) : null;
		}

		// Token: 0x06001222 RID: 4642 RVA: 0x00007725 File Offset: 0x00005925
		public TimerFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400142C RID: 5164
		private static readonly IntPtr NativeMethodInfoPtr_IsRunningOnMono_Private_Static_Boolean_0;

		// Token: 0x0400142D RID: 5165
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_ITimer_0;
	}
}
