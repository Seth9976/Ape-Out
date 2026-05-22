using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Il2CppRewired.Demos
{
	// Token: 0x02000214 RID: 532
	public sealed class UIPointer : UIBehaviour
	{
		// Token: 0x060040FA RID: 16634 RVA: 0x000F2724 File Offset: 0x000F0924
		// Note: this type is marked as 'beforefieldinit'.
		static UIPointer()
		{
			Il2CppClassPointerStore<UIPointer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos", "UIPointer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIPointer>.NativeClassPtr);
			UIPointer.NativeFieldInfoPtr__hideHardwarePointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPointer>.NativeClassPtr, "_hideHardwarePointer");
			UIPointer.NativeFieldInfoPtr__autoSort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPointer>.NativeClassPtr, "_autoSort");
			UIPointer.NativeFieldInfoPtr__canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPointer>.NativeClassPtr, "_canvas");
			UIPointer.NativeMethodInfoPtr_get_autoSort_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPointer>.NativeClassPtr, 100669634);
			UIPointer.NativeMethodInfoPtr_set_autoSort_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPointer>.NativeClassPtr, 100669635);
			UIPointer.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPointer>.NativeClassPtr, 100669636);
			UIPointer.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPointer>.NativeClassPtr, 100669637);
			UIPointer.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPointer>.NativeClassPtr, 100669638);
			UIPointer.NativeMethodInfoPtr_OnCanvasGroupChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPointer>.NativeClassPtr, 100669639);
			UIPointer.NativeMethodInfoPtr_OnScreenPositionChanged_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPointer>.NativeClassPtr, 100669640);
			UIPointer.NativeMethodInfoPtr_GetDependencies_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPointer>.NativeClassPtr, 100669641);
			UIPointer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPointer>.NativeClassPtr, 100669642);
		}

		// Token: 0x1700188E RID: 6286
		// (get) Token: 0x060040FB RID: 16635 RVA: 0x000F2844 File Offset: 0x000F0A44
		// (set) Token: 0x060040FC RID: 16636 RVA: 0x000F2880 File Offset: 0x000F0A80
		public unsafe bool autoSort
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPointer.NativeMethodInfoPtr_get_autoSort_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104559, XrefRangeEnd = 104563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPointer.NativeMethodInfoPtr_set_autoSort_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060040FD RID: 16637 RVA: 0x000F28C0 File Offset: 0x000F0AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104563, XrefRangeEnd = 104582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPointer.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040FE RID: 16638 RVA: 0x000F28F4 File Offset: 0x000F0AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104582, XrefRangeEnd = 104596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPointer.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040FF RID: 16639 RVA: 0x000F2928 File Offset: 0x000F0B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104596, XrefRangeEnd = 104597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnTransformParentChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPointer.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004100 RID: 16640 RVA: 0x000F295C File Offset: 0x000F0B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCanvasGroupChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPointer.NativeMethodInfoPtr_OnCanvasGroupChanged_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004101 RID: 16641 RVA: 0x000F2990 File Offset: 0x000F0B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104597, XrefRangeEnd = 104630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnScreenPositionChanged(Vector2 screenPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref screenPosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPointer.NativeMethodInfoPtr_OnScreenPositionChanged_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004102 RID: 16642 RVA: 0x000F29D0 File Offset: 0x000F0BD0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 104637, RefRangeEnd = 104640, XrefRangeStart = 104630, XrefRangeEnd = 104637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetDependencies()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPointer.NativeMethodInfoPtr_GetDependencies_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004103 RID: 16643 RVA: 0x000F2A04 File Offset: 0x000F0C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104640, XrefRangeEnd = 104643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIPointer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIPointer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPointer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004104 RID: 16644 RVA: 0x00027B35 File Offset: 0x00025D35
		public UIPointer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700188B RID: 6283
		// (get) Token: 0x06004105 RID: 16645 RVA: 0x000F2A40 File Offset: 0x000F0C40
		// (set) Token: 0x06004106 RID: 16646 RVA: 0x00027B3E File Offset: 0x00025D3E
		public unsafe bool _hideHardwarePointer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPointer.NativeFieldInfoPtr__hideHardwarePointer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPointer.NativeFieldInfoPtr__hideHardwarePointer)) = value;
			}
		}

		// Token: 0x1700188C RID: 6284
		// (get) Token: 0x06004107 RID: 16647 RVA: 0x000F2A68 File Offset: 0x000F0C68
		// (set) Token: 0x06004108 RID: 16648 RVA: 0x00027B59 File Offset: 0x00025D59
		public unsafe bool _autoSort
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPointer.NativeFieldInfoPtr__autoSort);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPointer.NativeFieldInfoPtr__autoSort)) = value;
			}
		}

		// Token: 0x1700188D RID: 6285
		// (get) Token: 0x06004109 RID: 16649 RVA: 0x000F2A90 File Offset: 0x000F0C90
		// (set) Token: 0x0600410A RID: 16650 RVA: 0x00027B74 File Offset: 0x00025D74
		public unsafe Canvas _canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPointer.NativeFieldInfoPtr__canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPointer.NativeFieldInfoPtr__canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040027EA RID: 10218
		private static readonly IntPtr NativeFieldInfoPtr__hideHardwarePointer;

		// Token: 0x040027EB RID: 10219
		private static readonly IntPtr NativeFieldInfoPtr__autoSort;

		// Token: 0x040027EC RID: 10220
		private static readonly IntPtr NativeFieldInfoPtr__canvas;

		// Token: 0x040027ED RID: 10221
		private static readonly IntPtr NativeMethodInfoPtr_get_autoSort_Public_get_Boolean_0;

		// Token: 0x040027EE RID: 10222
		private static readonly IntPtr NativeMethodInfoPtr_set_autoSort_Public_set_Void_Boolean_0;

		// Token: 0x040027EF RID: 10223
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040027F0 RID: 10224
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040027F1 RID: 10225
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0;

		// Token: 0x040027F2 RID: 10226
		private static readonly IntPtr NativeMethodInfoPtr_OnCanvasGroupChanged_Protected_Virtual_Void_0;

		// Token: 0x040027F3 RID: 10227
		private static readonly IntPtr NativeMethodInfoPtr_OnScreenPositionChanged_Public_Void_Vector2_0;

		// Token: 0x040027F4 RID: 10228
		private static readonly IntPtr NativeMethodInfoPtr_GetDependencies_Private_Void_0;

		// Token: 0x040027F5 RID: 10229
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
