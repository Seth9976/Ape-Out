using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppTMPro
{
	// Token: 0x0200003D RID: 61
	[Serializable]
	public class TMP_Sprite : TMP_TextElement_Legacy
	{
		// Token: 0x060006D5 RID: 1749 RVA: 0x0002059C File Offset: 0x0001E79C
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_Sprite()
		{
			Il2CppClassPointerStore<TMP_Sprite>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_Sprite");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Sprite>.NativeClassPtr);
			TMP_Sprite.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Sprite>.NativeClassPtr, "name");
			TMP_Sprite.NativeFieldInfoPtr_hashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Sprite>.NativeClassPtr, "hashCode");
			TMP_Sprite.NativeFieldInfoPtr_unicode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Sprite>.NativeClassPtr, "unicode");
			TMP_Sprite.NativeFieldInfoPtr_pivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Sprite>.NativeClassPtr, "pivot");
			TMP_Sprite.NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Sprite>.NativeClassPtr, "sprite");
			TMP_Sprite.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Sprite>.NativeClassPtr, 100664082);
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x00020644 File Offset: 0x0001E844
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_Sprite()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Sprite>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Sprite.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x000051AF File Offset: 0x000033AF
		public TMP_Sprite(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x060006D8 RID: 1752 RVA: 0x00020680 File Offset: 0x0001E880
		// (set) Token: 0x060006D9 RID: 1753 RVA: 0x000051B8 File Offset: 0x000033B8
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Sprite.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Sprite.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x060006DA RID: 1754 RVA: 0x000206A8 File Offset: 0x0001E8A8
		// (set) Token: 0x060006DB RID: 1755 RVA: 0x000051D7 File Offset: 0x000033D7
		public unsafe int hashCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Sprite.NativeFieldInfoPtr_hashCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Sprite.NativeFieldInfoPtr_hashCode)) = value;
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x060006DC RID: 1756 RVA: 0x000206D0 File Offset: 0x0001E8D0
		// (set) Token: 0x060006DD RID: 1757 RVA: 0x000051F2 File Offset: 0x000033F2
		public unsafe int unicode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Sprite.NativeFieldInfoPtr_unicode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Sprite.NativeFieldInfoPtr_unicode)) = value;
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x000206F8 File Offset: 0x0001E8F8
		// (set) Token: 0x060006DF RID: 1759 RVA: 0x0000520D File Offset: 0x0000340D
		public unsafe Vector2 pivot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Sprite.NativeFieldInfoPtr_pivot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Sprite.NativeFieldInfoPtr_pivot)) = value;
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x060006E0 RID: 1760 RVA: 0x00020720 File Offset: 0x0001E920
		// (set) Token: 0x060006E1 RID: 1761 RVA: 0x00005228 File Offset: 0x00003428
		public unsafe Sprite sprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Sprite.NativeFieldInfoPtr_sprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Sprite.NativeFieldInfoPtr_sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400057B RID: 1403
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x0400057C RID: 1404
		private static readonly IntPtr NativeFieldInfoPtr_hashCode;

		// Token: 0x0400057D RID: 1405
		private static readonly IntPtr NativeFieldInfoPtr_unicode;

		// Token: 0x0400057E RID: 1406
		private static readonly IntPtr NativeFieldInfoPtr_pivot;

		// Token: 0x0400057F RID: 1407
		private static readonly IntPtr NativeFieldInfoPtr_sprite;

		// Token: 0x04000580 RID: 1408
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
