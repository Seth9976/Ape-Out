using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000C1 RID: 193
	public class Emancipator : MonoBehaviour
	{
		// Token: 0x060016E5 RID: 5861 RVA: 0x00074D78 File Offset: 0x00072F78
		// Note: this type is marked as 'beforefieldinit'.
		static Emancipator()
		{
			Il2CppClassPointerStore<Emancipator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Emancipator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Emancipator>.NativeClassPtr);
			Emancipator.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Emancipator>.NativeClassPtr, 100665210);
			Emancipator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Emancipator>.NativeClassPtr, 100665211);
		}

		// Token: 0x060016E6 RID: 5862 RVA: 0x00074DD0 File Offset: 0x00072FD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56257, XrefRangeEnd = 56280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Emancipator.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016E7 RID: 5863 RVA: 0x00074E04 File Offset: 0x00073004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Emancipator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Emancipator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Emancipator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016E8 RID: 5864 RVA: 0x00010794 File Offset: 0x0000E994
		public Emancipator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000DA7 RID: 3495
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04000DA8 RID: 3496
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
