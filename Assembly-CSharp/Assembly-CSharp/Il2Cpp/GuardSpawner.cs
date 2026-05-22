using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000101 RID: 257
	public class GuardSpawner : MonoBehaviour
	{
		// Token: 0x06001DCE RID: 7630 RVA: 0x00088204 File Offset: 0x00086404
		// Note: this type is marked as 'beforefieldinit'.
		static GuardSpawner()
		{
			Il2CppClassPointerStore<GuardSpawner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GuardSpawner");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuardSpawner>.NativeClassPtr);
			GuardSpawner.NativeFieldInfoPtr_hangOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardSpawner>.NativeClassPtr, "hangOut");
			GuardSpawner.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardSpawner>.NativeClassPtr, 100665705);
			GuardSpawner.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardSpawner>.NativeClassPtr, 100665706);
		}

		// Token: 0x06001DCF RID: 7631 RVA: 0x00088270 File Offset: 0x00086470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64686, XrefRangeEnd = 64692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardSpawner.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DD0 RID: 7632 RVA: 0x000882A4 File Offset: 0x000864A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuardSpawner()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuardSpawner>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardSpawner.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DD1 RID: 7633 RVA: 0x00014DC7 File Offset: 0x00012FC7
		public GuardSpawner(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x06001DD2 RID: 7634 RVA: 0x000882E0 File Offset: 0x000864E0
		// (set) Token: 0x06001DD3 RID: 7635 RVA: 0x00014DD0 File Offset: 0x00012FD0
		public unsafe bool hangOut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardSpawner.NativeFieldInfoPtr_hangOut);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardSpawner.NativeFieldInfoPtr_hangOut)) = value;
			}
		}

		// Token: 0x040011B6 RID: 4534
		private static readonly IntPtr NativeFieldInfoPtr_hangOut;

		// Token: 0x040011B7 RID: 4535
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040011B8 RID: 4536
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
