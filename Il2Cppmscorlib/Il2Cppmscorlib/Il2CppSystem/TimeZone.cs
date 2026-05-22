using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200013B RID: 315
	[Serializable]
	public class TimeZone : Object
	{
		// Token: 0x060016D6 RID: 5846 RVA: 0x0008B664 File Offset: 0x00089864
		// Note: this type is marked as 'beforefieldinit'.
		static TimeZone()
		{
			Il2CppClassPointerStore<TimeZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TimeZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeZone>.NativeClassPtr);
			TimeZone.NativeFieldInfoPtr_tz_lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZone>.NativeClassPtr, "tz_lock");
			TimeZone.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZone>.NativeClassPtr, 100667198);
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x0008B6BC File Offset: 0x000898BC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeZone()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZone.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x00007E1C File Offset: 0x0000601C
		public TimeZone(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x060016D9 RID: 5849 RVA: 0x0008B6F8 File Offset: 0x000898F8
		// (set) Token: 0x060016DA RID: 5850 RVA: 0x00007E25 File Offset: 0x00006025
		public unsafe static Object tz_lock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimeZone.NativeFieldInfoPtr_tz_lock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeZone.NativeFieldInfoPtr_tz_lock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001506 RID: 5382
		private static readonly IntPtr NativeFieldInfoPtr_tz_lock;

		// Token: 0x04001507 RID: 5383
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
