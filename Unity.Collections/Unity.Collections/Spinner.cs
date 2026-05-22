using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x02000026 RID: 38
	[StructLayout(2)]
	public struct Spinner
	{
		// Token: 0x06000113 RID: 275 RVA: 0x0000A090 File Offset: 0x00008290
		// Note: this type is marked as 'beforefieldinit'.
		static Spinner()
		{
			Il2CppClassPointerStore<Spinner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Collections.dll", "Unity.Collections", "Spinner");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spinner>.NativeClassPtr);
			Spinner.NativeFieldInfoPtr_m_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spinner>.NativeClassPtr, "m_value");
			Spinner.NativeMethodInfoPtr_Lock_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spinner>.NativeClassPtr, 100663512);
			Spinner.NativeMethodInfoPtr_Unlock_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spinner>.NativeClassPtr, 100663513);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0000A0FC File Offset: 0x000082FC
		[CallerCount(0)]
		public unsafe void Lock()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spinner.NativeMethodInfoPtr_Lock_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000A124 File Offset: 0x00008324
		[CallerCount(0)]
		public unsafe void Unlock()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spinner.NativeMethodInfoPtr_Unlock_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000025ED File Offset: 0x000007ED
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Spinner>.NativeClassPtr, ref this));
		}

		// Token: 0x040003DE RID: 990
		private static readonly IntPtr NativeFieldInfoPtr_m_value;

		// Token: 0x040003DF RID: 991
		private static readonly IntPtr NativeMethodInfoPtr_Lock_Public_Void_0;

		// Token: 0x040003E0 RID: 992
		private static readonly IntPtr NativeMethodInfoPtr_Unlock_Public_Void_0;

		// Token: 0x040003E1 RID: 993
		[FieldOffset(0)]
		public int m_value;
	}
}
