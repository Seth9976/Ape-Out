using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppRewired.Demos.GamepadTemplateUI
{
	// Token: 0x0200021D RID: 541
	public class ControllerUIEffect : MonoBehaviour
	{
		// Token: 0x060041BB RID: 16827 RVA: 0x000F4BF8 File Offset: 0x000F2DF8
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerUIEffect()
		{
			Il2CppClassPointerStore<ControllerUIEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos.GamepadTemplateUI", "ControllerUIEffect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerUIEffect>.NativeClassPtr);
			ControllerUIEffect.NativeFieldInfoPtr__highlightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerUIEffect>.NativeClassPtr, "_highlightColor");
			ControllerUIEffect.NativeFieldInfoPtr__image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerUIEffect>.NativeClassPtr, "_image");
			ControllerUIEffect.NativeFieldInfoPtr__color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerUIEffect>.NativeClassPtr, "_color");
			ControllerUIEffect.NativeFieldInfoPtr__origColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerUIEffect>.NativeClassPtr, "_origColor");
			ControllerUIEffect.NativeFieldInfoPtr__isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerUIEffect>.NativeClassPtr, "_isActive");
			ControllerUIEffect.NativeFieldInfoPtr__highlightAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerUIEffect>.NativeClassPtr, "_highlightAmount");
			ControllerUIEffect.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerUIEffect>.NativeClassPtr, 100669730);
			ControllerUIEffect.NativeMethodInfoPtr_Activate_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerUIEffect>.NativeClassPtr, 100669731);
			ControllerUIEffect.NativeMethodInfoPtr_Deactivate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerUIEffect>.NativeClassPtr, 100669732);
			ControllerUIEffect.NativeMethodInfoPtr_RedrawImage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerUIEffect>.NativeClassPtr, 100669733);
			ControllerUIEffect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerUIEffect>.NativeClassPtr, 100669734);
		}

		// Token: 0x060041BC RID: 16828 RVA: 0x000F4D04 File Offset: 0x000F2F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105711, XrefRangeEnd = 105714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerUIEffect.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041BD RID: 16829 RVA: 0x000F4D38 File Offset: 0x000F2F38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 105717, RefRangeEnd = 105719, XrefRangeStart = 105714, XrefRangeEnd = 105717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Activate(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerUIEffect.NativeMethodInfoPtr_Activate_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060041BE RID: 16830 RVA: 0x000F4D78 File Offset: 0x000F2F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105719, XrefRangeEnd = 105720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerUIEffect.NativeMethodInfoPtr_Deactivate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041BF RID: 16831 RVA: 0x000F4DAC File Offset: 0x000F2FAC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 105725, RefRangeEnd = 105729, XrefRangeStart = 105720, XrefRangeEnd = 105725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RedrawImage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerUIEffect.NativeMethodInfoPtr_RedrawImage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041C0 RID: 16832 RVA: 0x000F4DE0 File Offset: 0x000F2FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105729, XrefRangeEnd = 105732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerUIEffect()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerUIEffect>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerUIEffect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041C1 RID: 16833 RVA: 0x0002813A File Offset: 0x0002633A
		public ControllerUIEffect(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170018C6 RID: 6342
		// (get) Token: 0x060041C2 RID: 16834 RVA: 0x000F4E1C File Offset: 0x000F301C
		// (set) Token: 0x060041C3 RID: 16835 RVA: 0x00028143 File Offset: 0x00026343
		public unsafe Color _highlightColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerUIEffect.NativeFieldInfoPtr__highlightColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerUIEffect.NativeFieldInfoPtr__highlightColor)) = value;
			}
		}

		// Token: 0x170018C7 RID: 6343
		// (get) Token: 0x060041C4 RID: 16836 RVA: 0x000F4E44 File Offset: 0x000F3044
		// (set) Token: 0x060041C5 RID: 16837 RVA: 0x0002815E File Offset: 0x0002635E
		public unsafe Image _image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerUIEffect.NativeFieldInfoPtr__image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerUIEffect.NativeFieldInfoPtr__image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018C8 RID: 6344
		// (get) Token: 0x060041C6 RID: 16838 RVA: 0x000F4E74 File Offset: 0x000F3074
		// (set) Token: 0x060041C7 RID: 16839 RVA: 0x0002817D File Offset: 0x0002637D
		public unsafe Color _color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerUIEffect.NativeFieldInfoPtr__color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerUIEffect.NativeFieldInfoPtr__color)) = value;
			}
		}

		// Token: 0x170018C9 RID: 6345
		// (get) Token: 0x060041C8 RID: 16840 RVA: 0x000F4E9C File Offset: 0x000F309C
		// (set) Token: 0x060041C9 RID: 16841 RVA: 0x00028198 File Offset: 0x00026398
		public unsafe Color _origColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerUIEffect.NativeFieldInfoPtr__origColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerUIEffect.NativeFieldInfoPtr__origColor)) = value;
			}
		}

		// Token: 0x170018CA RID: 6346
		// (get) Token: 0x060041CA RID: 16842 RVA: 0x000F4EC4 File Offset: 0x000F30C4
		// (set) Token: 0x060041CB RID: 16843 RVA: 0x000281B3 File Offset: 0x000263B3
		public unsafe bool _isActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerUIEffect.NativeFieldInfoPtr__isActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerUIEffect.NativeFieldInfoPtr__isActive)) = value;
			}
		}

		// Token: 0x170018CB RID: 6347
		// (get) Token: 0x060041CC RID: 16844 RVA: 0x000F4EEC File Offset: 0x000F30EC
		// (set) Token: 0x060041CD RID: 16845 RVA: 0x000281CE File Offset: 0x000263CE
		public unsafe float _highlightAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerUIEffect.NativeFieldInfoPtr__highlightAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerUIEffect.NativeFieldInfoPtr__highlightAmount)) = value;
			}
		}

		// Token: 0x04002865 RID: 10341
		private static readonly IntPtr NativeFieldInfoPtr__highlightColor;

		// Token: 0x04002866 RID: 10342
		private static readonly IntPtr NativeFieldInfoPtr__image;

		// Token: 0x04002867 RID: 10343
		private static readonly IntPtr NativeFieldInfoPtr__color;

		// Token: 0x04002868 RID: 10344
		private static readonly IntPtr NativeFieldInfoPtr__origColor;

		// Token: 0x04002869 RID: 10345
		private static readonly IntPtr NativeFieldInfoPtr__isActive;

		// Token: 0x0400286A RID: 10346
		private static readonly IntPtr NativeFieldInfoPtr__highlightAmount;

		// Token: 0x0400286B RID: 10347
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400286C RID: 10348
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Void_Single_0;

		// Token: 0x0400286D RID: 10349
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Public_Void_0;

		// Token: 0x0400286E RID: 10350
		private static readonly IntPtr NativeMethodInfoPtr_RedrawImage_Private_Void_0;

		// Token: 0x0400286F RID: 10351
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
