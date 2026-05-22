using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200013D RID: 317
	public class NumberPicker : MonoBehaviour
	{
		// Token: 0x0600269D RID: 9885 RVA: 0x0009F9D0 File Offset: 0x0009DBD0
		// Note: this type is marked as 'beforefieldinit'.
		static NumberPicker()
		{
			Il2CppClassPointerStore<NumberPicker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "NumberPicker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumberPicker>.NativeClassPtr);
			NumberPicker.NativeFieldInfoPtr_sprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberPicker>.NativeClassPtr, "sprites");
			NumberPicker.NativeFieldInfoPtr_renderer1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberPicker>.NativeClassPtr, "renderer1");
			NumberPicker.NativeFieldInfoPtr_renderer2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberPicker>.NativeClassPtr, "renderer2");
			NumberPicker.NativeFieldInfoPtr_p = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberPicker>.NativeClassPtr, "p");
			NumberPicker.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberPicker>.NativeClassPtr, 100666388);
			NumberPicker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberPicker>.NativeClassPtr, 100666389);
		}

		// Token: 0x0600269E RID: 9886 RVA: 0x0009FA78 File Offset: 0x0009DC78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74832, XrefRangeEnd = 74858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberPicker.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600269F RID: 9887 RVA: 0x0009FAAC File Offset: 0x0009DCAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NumberPicker()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NumberPicker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberPicker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026A0 RID: 9888 RVA: 0x0001AE6A File Offset: 0x0001906A
		public NumberPicker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DE2 RID: 3554
		// (get) Token: 0x060026A1 RID: 9889 RVA: 0x0009FAE8 File Offset: 0x0009DCE8
		// (set) Token: 0x060026A2 RID: 9890 RVA: 0x0001AE73 File Offset: 0x00019073
		public unsafe Il2CppReferenceArray<Sprite> sprites
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberPicker.NativeFieldInfoPtr_sprites);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberPicker.NativeFieldInfoPtr_sprites), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE3 RID: 3555
		// (get) Token: 0x060026A3 RID: 9891 RVA: 0x0009FB18 File Offset: 0x0009DD18
		// (set) Token: 0x060026A4 RID: 9892 RVA: 0x0001AE92 File Offset: 0x00019092
		public unsafe SpriteRenderer renderer1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberPicker.NativeFieldInfoPtr_renderer1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberPicker.NativeFieldInfoPtr_renderer1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE4 RID: 3556
		// (get) Token: 0x060026A5 RID: 9893 RVA: 0x0009FB48 File Offset: 0x0009DD48
		// (set) Token: 0x060026A6 RID: 9894 RVA: 0x0001AEB1 File Offset: 0x000190B1
		public unsafe SpriteRenderer renderer2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberPicker.NativeFieldInfoPtr_renderer2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberPicker.NativeFieldInfoPtr_renderer2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE5 RID: 3557
		// (get) Token: 0x060026A7 RID: 9895 RVA: 0x0009FB78 File Offset: 0x0009DD78
		// (set) Token: 0x060026A8 RID: 9896 RVA: 0x0001AED0 File Offset: 0x000190D0
		public unsafe Transform p
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberPicker.NativeFieldInfoPtr_p);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberPicker.NativeFieldInfoPtr_p), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040016CC RID: 5836
		private static readonly IntPtr NativeFieldInfoPtr_sprites;

		// Token: 0x040016CD RID: 5837
		private static readonly IntPtr NativeFieldInfoPtr_renderer1;

		// Token: 0x040016CE RID: 5838
		private static readonly IntPtr NativeFieldInfoPtr_renderer2;

		// Token: 0x040016CF RID: 5839
		private static readonly IntPtr NativeFieldInfoPtr_p;

		// Token: 0x040016D0 RID: 5840
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040016D1 RID: 5841
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
