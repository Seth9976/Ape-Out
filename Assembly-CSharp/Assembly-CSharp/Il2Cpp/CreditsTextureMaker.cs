using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000B3 RID: 179
	public class CreditsTextureMaker : ScriptableObject
	{
		// Token: 0x060015DA RID: 5594 RVA: 0x00071F74 File Offset: 0x00070174
		// Note: this type is marked as 'beforefieldinit'.
		static CreditsTextureMaker()
		{
			Il2CppClassPointerStore<CreditsTextureMaker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CreditsTextureMaker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreditsTextureMaker>.NativeClassPtr);
			CreditsTextureMaker.NativeFieldInfoPtr_colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreditsTextureMaker>.NativeClassPtr, "colors");
			CreditsTextureMaker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreditsTextureMaker>.NativeClassPtr, 100665127);
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x00071FCC File Offset: 0x000701CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CreditsTextureMaker()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreditsTextureMaker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreditsTextureMaker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x0000FD7A File Offset: 0x0000DF7A
		public CreditsTextureMaker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x060015DD RID: 5597 RVA: 0x00072008 File Offset: 0x00070208
		// (set) Token: 0x060015DE RID: 5598 RVA: 0x0000FD83 File Offset: 0x0000DF83
		public unsafe Il2CppStructArray<Color> colors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreditsTextureMaker.NativeFieldInfoPtr_colors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreditsTextureMaker.NativeFieldInfoPtr_colors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D0C RID: 3340
		private static readonly IntPtr NativeFieldInfoPtr_colors;

		// Token: 0x04000D0D RID: 3341
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
