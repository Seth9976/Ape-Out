using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000FD RID: 253
	public class SystemClock : Object
	{
		// Token: 0x06001556 RID: 5462 RVA: 0x000539CC File Offset: 0x00051BCC
		// Note: this type is marked as 'beforefieldinit'.
		static SystemClock()
		{
			Il2CppClassPointerStore<SystemClock>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "SystemClock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemClock>.NativeClassPtr);
			SystemClock.NativeFieldInfoPtr_s_Epoch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemClock>.NativeClassPtr, "s_Epoch");
			SystemClock.NativeMethodInfoPtr_get_now_Public_Static_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemClock>.NativeClassPtr, 100665126);
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06001557 RID: 5463 RVA: 0x00053A24 File Offset: 0x00051C24
		public unsafe static DateTime now
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 498550, RefRangeEnd = 498552, XrefRangeStart = 498543, XrefRangeEnd = 498550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemClock.NativeMethodInfoPtr_get_now_Public_Static_get_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x0000BC4C File Offset: 0x00009E4C
		public SystemClock(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06001559 RID: 5465 RVA: 0x00053A54 File Offset: 0x00051C54
		// (set) Token: 0x0600155A RID: 5466 RVA: 0x0000BC55 File Offset: 0x00009E55
		public unsafe static DateTime s_Epoch
		{
			get
			{
				DateTime dateTime;
				IL2CPP.il2cpp_field_static_get_value(SystemClock.NativeFieldInfoPtr_s_Epoch, (void*)(&dateTime));
				return dateTime;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SystemClock.NativeFieldInfoPtr_s_Epoch, (void*)(&value));
			}
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x00053A70 File Offset: 0x00051C70
		public static long ToUnixTimeMilliseconds(DateTime date)
		{
			return Convert.ToInt64((date.ToUniversalTime() - SystemClock.s_Epoch).TotalMilliseconds);
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x00053AA0 File Offset: 0x00051CA0
		public static long ToUnixTimeSeconds(DateTime date)
		{
			return Convert.ToInt64((date.ToUniversalTime() - SystemClock.s_Epoch).TotalSeconds);
		}

		// Token: 0x0400109D RID: 4253
		private static readonly IntPtr NativeFieldInfoPtr_s_Epoch;

		// Token: 0x0400109E RID: 4254
		private static readonly IntPtr NativeMethodInfoPtr_get_now_Public_Static_get_DateTime_0;
	}
}
