using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppTMPro
{
	// Token: 0x0200001E RID: 30
	[Serializable]
	public sealed class TMP_FontWeightPair : ValueType
	{
		// Token: 0x06000300 RID: 768 RVA: 0x00013C74 File Offset: 0x00011E74
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_FontWeightPair()
		{
			Il2CppClassPointerStore<TMP_FontWeightPair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_FontWeightPair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_FontWeightPair>.NativeClassPtr);
			TMP_FontWeightPair.NativeFieldInfoPtr_regularTypeface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontWeightPair>.NativeClassPtr, "regularTypeface");
			TMP_FontWeightPair.NativeFieldInfoPtr_italicTypeface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontWeightPair>.NativeClassPtr, "italicTypeface");
		}

		// Token: 0x06000301 RID: 769 RVA: 0x000038E4 File Offset: 0x00001AE4
		public TMP_FontWeightPair(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000302 RID: 770 RVA: 0x000038ED File Offset: 0x00001AED
		public TMP_FontWeightPair()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_FontWeightPair>.NativeClassPtr))
		{
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000303 RID: 771 RVA: 0x00013CCC File Offset: 0x00011ECC
		// (set) Token: 0x06000304 RID: 772 RVA: 0x000038FF File Offset: 0x00001AFF
		public unsafe TMP_FontAsset regularTypeface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontWeightPair.NativeFieldInfoPtr_regularTypeface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontWeightPair.NativeFieldInfoPtr_regularTypeface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000305 RID: 773 RVA: 0x00013CFC File Offset: 0x00011EFC
		// (set) Token: 0x06000306 RID: 774 RVA: 0x0000391E File Offset: 0x00001B1E
		public unsafe TMP_FontAsset italicTypeface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontWeightPair.NativeFieldInfoPtr_italicTypeface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FontWeightPair.NativeFieldInfoPtr_italicTypeface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400020D RID: 525
		private static readonly IntPtr NativeFieldInfoPtr_regularTypeface;

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeFieldInfoPtr_italicTypeface;
	}
}
