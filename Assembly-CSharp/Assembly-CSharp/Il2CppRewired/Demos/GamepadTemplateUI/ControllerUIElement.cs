using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppRewired.Demos.GamepadTemplateUI
{
	// Token: 0x0200021E RID: 542
	public class ControllerUIElement : MonoBehaviour
	{
		// Token: 0x060041CE RID: 16846 RVA: 0x000F4F14 File Offset: 0x000F3114
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerUIElement()
		{
			Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos.GamepadTemplateUI", "ControllerUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr);
			ControllerUIElement.NativeFieldInfoPtr__highlightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr, "_highlightColor");
			ControllerUIElement.NativeFieldInfoPtr__positiveUIEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr, "_positiveUIEffect");
			ControllerUIElement.NativeFieldInfoPtr__negativeUIEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr, "_negativeUIEffect");
			ControllerUIElement.NativeFieldInfoPtr__label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr, "_label");
			ControllerUIElement.NativeFieldInfoPtr__positiveLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr, "_positiveLabel");
			ControllerUIElement.NativeFieldInfoPtr__negativeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr, "_negativeLabel");
			ControllerUIElement.NativeFieldInfoPtr__childElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr, "_childElements");
			ControllerUIElement.NativeFieldInfoPtr__image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr, "_image");
			ControllerUIElement.NativeFieldInfoPtr__color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr, "_color");
			ControllerUIElement.NativeFieldInfoPtr__origColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr, "_origColor");
			ControllerUIElement.NativeFieldInfoPtr__isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr, "_isActive");
			ControllerUIElement.NativeFieldInfoPtr__highlightAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr, "_highlightAmount");
			ControllerUIElement.NativeMethodInfoPtr_get_hasEffects_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr, 100669735);
			ControllerUIElement.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr, 100669736);
			ControllerUIElement.NativeMethodInfoPtr_Activate_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr, 100669737);
			ControllerUIElement.NativeMethodInfoPtr_Deactivate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr, 100669738);
			ControllerUIElement.NativeMethodInfoPtr_SetLabel_Public_Void_String_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr, 100669739);
			ControllerUIElement.NativeMethodInfoPtr_ClearLabels_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr, 100669740);
			ControllerUIElement.NativeMethodInfoPtr_RedrawImage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr, 100669741);
			ControllerUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr, 100669742);
		}

		// Token: 0x170018D8 RID: 6360
		// (get) Token: 0x060041CF RID: 16847 RVA: 0x000F50D4 File Offset: 0x000F32D4
		public unsafe bool hasEffects
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 105746, RefRangeEnd = 105747, XrefRangeStart = 105732, XrefRangeEnd = 105746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerUIElement.NativeMethodInfoPtr_get_hasEffects_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060041D0 RID: 16848 RVA: 0x000F5110 File Offset: 0x000F3310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105747, XrefRangeEnd = 105752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerUIElement.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041D1 RID: 16849 RVA: 0x000F5144 File Offset: 0x000F3344
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 105799, RefRangeEnd = 105801, XrefRangeStart = 105752, XrefRangeEnd = 105799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Activate(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerUIElement.NativeMethodInfoPtr_Activate_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060041D2 RID: 16850 RVA: 0x000F5184 File Offset: 0x000F3384
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 105844, RefRangeEnd = 105846, XrefRangeStart = 105801, XrefRangeEnd = 105844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerUIElement.NativeMethodInfoPtr_Deactivate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041D3 RID: 16851 RVA: 0x000F51B8 File Offset: 0x000F33B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 105879, RefRangeEnd = 105881, XrefRangeStart = 105846, XrefRangeEnd = 105879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLabel(string text, AxisRange labelType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref labelType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerUIElement.NativeMethodInfoPtr_SetLabel_Public_Void_String_AxisRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041D4 RID: 16852 RVA: 0x000F5208 File Offset: 0x000F3408
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 105941, RefRangeEnd = 105944, XrefRangeStart = 105881, XrefRangeEnd = 105941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearLabels()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerUIElement.NativeMethodInfoPtr_ClearLabels_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041D5 RID: 16853 RVA: 0x000F523C File Offset: 0x000F343C
		[CallerCount(0)]
		public unsafe void RedrawImage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerUIElement.NativeMethodInfoPtr_RedrawImage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041D6 RID: 16854 RVA: 0x000F5270 File Offset: 0x000F3470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105944, XrefRangeEnd = 105950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerUIElement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerUIElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041D7 RID: 16855 RVA: 0x000281E9 File Offset: 0x000263E9
		public ControllerUIElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170018CC RID: 6348
		// (get) Token: 0x060041D8 RID: 16856 RVA: 0x000F52AC File Offset: 0x000F34AC
		// (set) Token: 0x060041D9 RID: 16857 RVA: 0x000281F2 File Offset: 0x000263F2
		public unsafe Color _highlightColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__highlightColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__highlightColor)) = value;
			}
		}

		// Token: 0x170018CD RID: 6349
		// (get) Token: 0x060041DA RID: 16858 RVA: 0x000F52D4 File Offset: 0x000F34D4
		// (set) Token: 0x060041DB RID: 16859 RVA: 0x0002820D File Offset: 0x0002640D
		public unsafe ControllerUIEffect _positiveUIEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__positiveUIEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerUIEffect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__positiveUIEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018CE RID: 6350
		// (get) Token: 0x060041DC RID: 16860 RVA: 0x000F5304 File Offset: 0x000F3504
		// (set) Token: 0x060041DD RID: 16861 RVA: 0x0002822C File Offset: 0x0002642C
		public unsafe ControllerUIEffect _negativeUIEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__negativeUIEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerUIEffect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__negativeUIEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018CF RID: 6351
		// (get) Token: 0x060041DE RID: 16862 RVA: 0x000F5334 File Offset: 0x000F3534
		// (set) Token: 0x060041DF RID: 16863 RVA: 0x0002824B File Offset: 0x0002644B
		public unsafe Text _label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018D0 RID: 6352
		// (get) Token: 0x060041E0 RID: 16864 RVA: 0x000F5364 File Offset: 0x000F3564
		// (set) Token: 0x060041E1 RID: 16865 RVA: 0x0002826A File Offset: 0x0002646A
		public unsafe Text _positiveLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__positiveLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__positiveLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018D1 RID: 6353
		// (get) Token: 0x060041E2 RID: 16866 RVA: 0x000F5394 File Offset: 0x000F3594
		// (set) Token: 0x060041E3 RID: 16867 RVA: 0x00028289 File Offset: 0x00026489
		public unsafe Text _negativeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__negativeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__negativeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018D2 RID: 6354
		// (get) Token: 0x060041E4 RID: 16868 RVA: 0x000F53C4 File Offset: 0x000F35C4
		// (set) Token: 0x060041E5 RID: 16869 RVA: 0x000282A8 File Offset: 0x000264A8
		public unsafe Il2CppReferenceArray<ControllerUIElement> _childElements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__childElements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ControllerUIElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__childElements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018D3 RID: 6355
		// (get) Token: 0x060041E6 RID: 16870 RVA: 0x000F53F4 File Offset: 0x000F35F4
		// (set) Token: 0x060041E7 RID: 16871 RVA: 0x000282C7 File Offset: 0x000264C7
		public unsafe Image _image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018D4 RID: 6356
		// (get) Token: 0x060041E8 RID: 16872 RVA: 0x000F5424 File Offset: 0x000F3624
		// (set) Token: 0x060041E9 RID: 16873 RVA: 0x000282E6 File Offset: 0x000264E6
		public unsafe Color _color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__color)) = value;
			}
		}

		// Token: 0x170018D5 RID: 6357
		// (get) Token: 0x060041EA RID: 16874 RVA: 0x000F544C File Offset: 0x000F364C
		// (set) Token: 0x060041EB RID: 16875 RVA: 0x00028301 File Offset: 0x00026501
		public unsafe Color _origColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__origColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__origColor)) = value;
			}
		}

		// Token: 0x170018D6 RID: 6358
		// (get) Token: 0x060041EC RID: 16876 RVA: 0x000F5474 File Offset: 0x000F3674
		// (set) Token: 0x060041ED RID: 16877 RVA: 0x0002831C File Offset: 0x0002651C
		public unsafe bool _isActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__isActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__isActive)) = value;
			}
		}

		// Token: 0x170018D7 RID: 6359
		// (get) Token: 0x060041EE RID: 16878 RVA: 0x000F549C File Offset: 0x000F369C
		// (set) Token: 0x060041EF RID: 16879 RVA: 0x00028337 File Offset: 0x00026537
		public unsafe float _highlightAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__highlightAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerUIElement.NativeFieldInfoPtr__highlightAmount)) = value;
			}
		}

		// Token: 0x04002870 RID: 10352
		private static readonly IntPtr NativeFieldInfoPtr__highlightColor;

		// Token: 0x04002871 RID: 10353
		private static readonly IntPtr NativeFieldInfoPtr__positiveUIEffect;

		// Token: 0x04002872 RID: 10354
		private static readonly IntPtr NativeFieldInfoPtr__negativeUIEffect;

		// Token: 0x04002873 RID: 10355
		private static readonly IntPtr NativeFieldInfoPtr__label;

		// Token: 0x04002874 RID: 10356
		private static readonly IntPtr NativeFieldInfoPtr__positiveLabel;

		// Token: 0x04002875 RID: 10357
		private static readonly IntPtr NativeFieldInfoPtr__negativeLabel;

		// Token: 0x04002876 RID: 10358
		private static readonly IntPtr NativeFieldInfoPtr__childElements;

		// Token: 0x04002877 RID: 10359
		private static readonly IntPtr NativeFieldInfoPtr__image;

		// Token: 0x04002878 RID: 10360
		private static readonly IntPtr NativeFieldInfoPtr__color;

		// Token: 0x04002879 RID: 10361
		private static readonly IntPtr NativeFieldInfoPtr__origColor;

		// Token: 0x0400287A RID: 10362
		private static readonly IntPtr NativeFieldInfoPtr__isActive;

		// Token: 0x0400287B RID: 10363
		private static readonly IntPtr NativeFieldInfoPtr__highlightAmount;

		// Token: 0x0400287C RID: 10364
		private static readonly IntPtr NativeMethodInfoPtr_get_hasEffects_Private_get_Boolean_0;

		// Token: 0x0400287D RID: 10365
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400287E RID: 10366
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Void_Single_0;

		// Token: 0x0400287F RID: 10367
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Public_Void_0;

		// Token: 0x04002880 RID: 10368
		private static readonly IntPtr NativeMethodInfoPtr_SetLabel_Public_Void_String_AxisRange_0;

		// Token: 0x04002881 RID: 10369
		private static readonly IntPtr NativeMethodInfoPtr_ClearLabels_Public_Void_0;

		// Token: 0x04002882 RID: 10370
		private static readonly IntPtr NativeMethodInfoPtr_RedrawImage_Private_Void_0;

		// Token: 0x04002883 RID: 10371
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
