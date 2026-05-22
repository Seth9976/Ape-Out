using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000266 RID: 614
	[StructLayout(2)]
	public struct SpinWait
	{
		// Token: 0x06002B0A RID: 11018 RVA: 0x000E0338 File Offset: 0x000DE538
		// Note: this type is marked as 'beforefieldinit'.
		static SpinWait()
		{
			Il2CppClassPointerStore<SpinWait>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "SpinWait");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpinWait>.NativeClassPtr);
			SpinWait.NativeFieldInfoPtr_m_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpinWait>.NativeClassPtr, "m_count");
			SpinWait.NativeMethodInfoPtr_get_NextSpinWillYield_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinWait>.NativeClassPtr, 100670212);
			SpinWait.NativeMethodInfoPtr_SpinOnce_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinWait>.NativeClassPtr, 100670213);
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x06002B0B RID: 11019 RVA: 0x000E03A4 File Offset: 0x000DE5A4
		public unsafe bool NextSpinWillYield
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpinWait.NativeMethodInfoPtr_get_NextSpinWillYield_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B0C RID: 11020 RVA: 0x000E03D4 File Offset: 0x000DE5D4
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 200938, RefRangeEnd = 200951, XrefRangeStart = 200929, XrefRangeEnd = 200938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpinOnce()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpinWait.NativeMethodInfoPtr_SpinOnce_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B0D RID: 11021 RVA: 0x0000EDC3 File Offset: 0x0000CFC3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpinWait>.NativeClassPtr, ref this));
		}

		// Token: 0x040025C0 RID: 9664
		private static readonly IntPtr NativeFieldInfoPtr_m_count;

		// Token: 0x040025C1 RID: 9665
		private static readonly IntPtr NativeMethodInfoPtr_get_NextSpinWillYield_Public_get_Boolean_0;

		// Token: 0x040025C2 RID: 9666
		private static readonly IntPtr NativeMethodInfoPtr_SpinOnce_Public_Void_0;

		// Token: 0x040025C3 RID: 9667
		[FieldOffset(0)]
		public int m_count;
	}
}
