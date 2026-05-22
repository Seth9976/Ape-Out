using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UI
{
	// Token: 0x0200000D RID: 13
	public static class DefaultControls : Object
	{
		// Token: 0x06000094 RID: 148 RVA: 0x00008F54 File Offset: 0x00007154
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultControls()
		{
			Il2CppClassPointerStore<DefaultControls>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "DefaultControls");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr);
			DefaultControls.NativeFieldInfoPtr_m_CurrentFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, "m_CurrentFactory");
			DefaultControls.NativeFieldInfoPtr_kWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, "kWidth");
			DefaultControls.NativeFieldInfoPtr_kThickHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, "kThickHeight");
			DefaultControls.NativeFieldInfoPtr_kThinHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, "kThinHeight");
			DefaultControls.NativeFieldInfoPtr_s_ThickElementSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, "s_ThickElementSize");
			DefaultControls.NativeFieldInfoPtr_s_ThinElementSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, "s_ThinElementSize");
			DefaultControls.NativeFieldInfoPtr_s_ImageElementSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, "s_ImageElementSize");
			DefaultControls.NativeFieldInfoPtr_s_DefaultSelectableColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, "s_DefaultSelectableColor");
			DefaultControls.NativeFieldInfoPtr_s_PanelColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, "s_PanelColor");
			DefaultControls.NativeFieldInfoPtr_s_TextColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, "s_TextColor");
			DefaultControls.NativeMethodInfoPtr_get_factory_Public_Static_get_IFactoryControls_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663385);
			DefaultControls.NativeMethodInfoPtr_CreateUIElementRoot_Private_Static_GameObject_String_Vector2_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663386);
			DefaultControls.NativeMethodInfoPtr_CreateUIObject_Private_Static_GameObject_String_GameObject_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663387);
			DefaultControls.NativeMethodInfoPtr_SetDefaultTextValues_Private_Static_Void_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663388);
			DefaultControls.NativeMethodInfoPtr_SetDefaultColorTransitionValues_Private_Static_Void_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663389);
			DefaultControls.NativeMethodInfoPtr_SetParentAndAlign_Private_Static_Void_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663390);
			DefaultControls.NativeMethodInfoPtr_SetLayerRecursively_Private_Static_Void_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663391);
			DefaultControls.NativeMethodInfoPtr_CreatePanel_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663392);
			DefaultControls.NativeMethodInfoPtr_CreateButton_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663393);
			DefaultControls.NativeMethodInfoPtr_CreateText_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663394);
			DefaultControls.NativeMethodInfoPtr_CreateImage_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663395);
			DefaultControls.NativeMethodInfoPtr_CreateRawImage_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663396);
			DefaultControls.NativeMethodInfoPtr_CreateSlider_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663397);
			DefaultControls.NativeMethodInfoPtr_CreateScrollbar_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663398);
			DefaultControls.NativeMethodInfoPtr_CreateToggle_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663399);
			DefaultControls.NativeMethodInfoPtr_CreateInputField_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663400);
			DefaultControls.NativeMethodInfoPtr_CreateDropdown_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663401);
			DefaultControls.NativeMethodInfoPtr_CreateScrollView_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663402);
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000095 RID: 149 RVA: 0x000091B4 File Offset: 0x000073B4
		public unsafe static DefaultControls.IFactoryControls factory
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516296, XrefRangeEnd = 516300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_get_factory_Public_Static_get_IFactoryControls_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DefaultControls.IFactoryControls>(intPtr3) : null;
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000091E8 File Offset: 0x000073E8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 516311, RefRangeEnd = 516322, XrefRangeStart = 516300, XrefRangeEnd = 516311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateUIElementRoot(string name, Vector2 size, [Optional] Il2CppReferenceArray<Type> components)
		{
			if (components == null)
			{
				components = new Il2CppReferenceArray<Type>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(components);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_CreateUIElementRoot_Private_Static_GameObject_String_Vector2_Il2CppReferenceArray_1_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000925C File Offset: 0x0000745C
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 516329, RefRangeEnd = 516353, XrefRangeStart = 516322, XrefRangeEnd = 516329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateUIObject(string name, GameObject parent, [Optional] Il2CppReferenceArray<Type> components)
		{
			if (components == null)
			{
				components = new Il2CppReferenceArray<Type>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(components);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_CreateUIObject_Private_Static_GameObject_String_GameObject_Il2CppReferenceArray_1_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000092D4 File Offset: 0x000074D4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 516362, RefRangeEnd = 516368, XrefRangeStart = 516353, XrefRangeEnd = 516362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetDefaultTextValues(Text lbl)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lbl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_SetDefaultTextValues_Private_Static_Void_Text_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000930C File Offset: 0x0000750C
		[CallerCount(0)]
		public unsafe static void SetDefaultColorTransitionValues(Selectable slider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_SetDefaultColorTransitionValues_Private_Static_Void_Selectable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00009344 File Offset: 0x00007544
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 516391, RefRangeEnd = 516395, XrefRangeStart = 516368, XrefRangeEnd = 516391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetParentAndAlign(GameObject child, GameObject parent)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_SetParentAndAlign_Private_Static_Void_GameObject_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000938C File Offset: 0x0000758C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 516410, RefRangeEnd = 516412, XrefRangeStart = 516395, XrefRangeEnd = 516410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetLayerRecursively(GameObject go, int layer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_SetLayerRecursively_Private_Static_Void_GameObject_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000093D0 File Offset: 0x000075D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516412, XrefRangeEnd = 516457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreatePanel(DefaultControls.Resources resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resources));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_CreatePanel_Public_Static_GameObject_Resources_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000941C File Offset: 0x0000761C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516457, XrefRangeEnd = 516521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateButton(DefaultControls.Resources resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resources));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_CreateButton_Public_Static_GameObject_Resources_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00009468 File Offset: 0x00007668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516521, XrefRangeEnd = 516545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateText(DefaultControls.Resources resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resources));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_CreateText_Public_Static_GameObject_Resources_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000094B4 File Offset: 0x000076B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516545, XrefRangeEnd = 516566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateImage(DefaultControls.Resources resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resources));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_CreateImage_Public_Static_GameObject_Resources_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00009500 File Offset: 0x00007700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516566, XrefRangeEnd = 516587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateRawImage(DefaultControls.Resources resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resources));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_CreateRawImage_Public_Static_GameObject_Resources_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000954C File Offset: 0x0000774C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516587, XrefRangeEnd = 516731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateSlider(DefaultControls.Resources resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resources));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_CreateSlider_Public_Static_GameObject_Resources_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00009598 File Offset: 0x00007798
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 516817, RefRangeEnd = 516820, XrefRangeStart = 516731, XrefRangeEnd = 516817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateScrollbar(DefaultControls.Resources resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resources));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_CreateScrollbar_Public_Static_GameObject_Resources_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000095E4 File Offset: 0x000077E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516820, XrefRangeEnd = 516922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateToggle(DefaultControls.Resources resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resources));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_CreateToggle_Public_Static_GameObject_Resources_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00009630 File Offset: 0x00007830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516922, XrefRangeEnd = 517022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateInputField(DefaultControls.Resources resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resources));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_CreateInputField_Public_Static_GameObject_Resources_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000967C File Offset: 0x0000787C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 517022, XrefRangeEnd = 517360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateDropdown(DefaultControls.Resources resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resources));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_CreateDropdown_Public_Static_GameObject_Resources_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000096C8 File Offset: 0x000078C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 517360, XrefRangeEnd = 517523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateScrollView(DefaultControls.Resources resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resources));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_CreateScrollView_Public_Static_GameObject_Resources_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002375 File Offset: 0x00000575
		public static GameObject CreateUIElementRoot(string name, Vector2 size, params Type[] components)
		{
			return DefaultControls.CreateUIElementRoot(name, size, new Il2CppReferenceArray<Type>(components));
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002384 File Offset: 0x00000584
		public static GameObject CreateUIObject(string name, GameObject parent, params Type[] components)
		{
			return DefaultControls.CreateUIObject(name, parent, new Il2CppReferenceArray<Type>(components));
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002393 File Offset: 0x00000593
		public DefaultControls(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00009714 File Offset: 0x00007914
		// (set) Token: 0x060000AB RID: 171 RVA: 0x0000239C File Offset: 0x0000059C
		public unsafe static DefaultControls.IFactoryControls m_CurrentFactory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DefaultControls.NativeFieldInfoPtr_m_CurrentFactory, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DefaultControls.IFactoryControls>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultControls.NativeFieldInfoPtr_m_CurrentFactory, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000AC RID: 172 RVA: 0x0000973C File Offset: 0x0000793C
		// (set) Token: 0x060000AD RID: 173 RVA: 0x000023AE File Offset: 0x000005AE
		public unsafe static float kWidth
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DefaultControls.NativeFieldInfoPtr_kWidth, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultControls.NativeFieldInfoPtr_kWidth, (void*)(&value));
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00009758 File Offset: 0x00007958
		// (set) Token: 0x060000AF RID: 175 RVA: 0x000023BC File Offset: 0x000005BC
		public unsafe static float kThickHeight
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DefaultControls.NativeFieldInfoPtr_kThickHeight, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultControls.NativeFieldInfoPtr_kThickHeight, (void*)(&value));
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00009774 File Offset: 0x00007974
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x000023CA File Offset: 0x000005CA
		public unsafe static float kThinHeight
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DefaultControls.NativeFieldInfoPtr_kThinHeight, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultControls.NativeFieldInfoPtr_kThinHeight, (void*)(&value));
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00009790 File Offset: 0x00007990
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x000023D8 File Offset: 0x000005D8
		public unsafe static Vector2 s_ThickElementSize
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(DefaultControls.NativeFieldInfoPtr_s_ThickElementSize, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultControls.NativeFieldInfoPtr_s_ThickElementSize, (void*)(&value));
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x000097AC File Offset: 0x000079AC
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x000023E6 File Offset: 0x000005E6
		public unsafe static Vector2 s_ThinElementSize
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(DefaultControls.NativeFieldInfoPtr_s_ThinElementSize, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultControls.NativeFieldInfoPtr_s_ThinElementSize, (void*)(&value));
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x000097C8 File Offset: 0x000079C8
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x000023F4 File Offset: 0x000005F4
		public unsafe static Vector2 s_ImageElementSize
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(DefaultControls.NativeFieldInfoPtr_s_ImageElementSize, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultControls.NativeFieldInfoPtr_s_ImageElementSize, (void*)(&value));
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x000097E4 File Offset: 0x000079E4
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x00002402 File Offset: 0x00000602
		public unsafe static Color s_DefaultSelectableColor
		{
			get
			{
				Color color;
				IL2CPP.il2cpp_field_static_get_value(DefaultControls.NativeFieldInfoPtr_s_DefaultSelectableColor, (void*)(&color));
				return color;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultControls.NativeFieldInfoPtr_s_DefaultSelectableColor, (void*)(&value));
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00009800 File Offset: 0x00007A00
		// (set) Token: 0x060000BB RID: 187 RVA: 0x00002410 File Offset: 0x00000610
		public unsafe static Color s_PanelColor
		{
			get
			{
				Color color;
				IL2CPP.il2cpp_field_static_get_value(DefaultControls.NativeFieldInfoPtr_s_PanelColor, (void*)(&color));
				return color;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultControls.NativeFieldInfoPtr_s_PanelColor, (void*)(&value));
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000BC RID: 188 RVA: 0x0000981C File Offset: 0x00007A1C
		// (set) Token: 0x060000BD RID: 189 RVA: 0x0000241E File Offset: 0x0000061E
		public unsafe static Color s_TextColor
		{
			get
			{
				Color color;
				IL2CPP.il2cpp_field_static_get_value(DefaultControls.NativeFieldInfoPtr_s_TextColor, (void*)(&color));
				return color;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultControls.NativeFieldInfoPtr_s_TextColor, (void*)(&value));
			}
		}

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentFactory;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeFieldInfoPtr_kWidth;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeFieldInfoPtr_kThickHeight;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeFieldInfoPtr_kThinHeight;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeFieldInfoPtr_s_ThickElementSize;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeFieldInfoPtr_s_ThinElementSize;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeFieldInfoPtr_s_ImageElementSize;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultSelectableColor;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeFieldInfoPtr_s_PanelColor;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeFieldInfoPtr_s_TextColor;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_get_factory_Public_Static_get_IFactoryControls_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_CreateUIElementRoot_Private_Static_GameObject_String_Vector2_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_CreateUIObject_Private_Static_GameObject_String_GameObject_Il2CppReferenceArray_1_Type_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaultTextValues_Private_Static_Void_Text_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaultColorTransitionValues_Private_Static_Void_Selectable_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_SetParentAndAlign_Private_Static_Void_GameObject_GameObject_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_SetLayerRecursively_Private_Static_Void_GameObject_Int32_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_CreatePanel_Public_Static_GameObject_Resources_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_CreateButton_Public_Static_GameObject_Resources_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_CreateText_Public_Static_GameObject_Resources_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_CreateImage_Public_Static_GameObject_Resources_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_CreateRawImage_Public_Static_GameObject_Resources_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_CreateSlider_Public_Static_GameObject_Resources_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_CreateScrollbar_Public_Static_GameObject_Resources_0;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_CreateToggle_Public_Static_GameObject_Resources_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_CreateInputField_Public_Static_GameObject_Resources_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_CreateDropdown_Public_Static_GameObject_Resources_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_CreateScrollView_Public_Static_GameObject_Resources_0;

		// Token: 0x02000076 RID: 118
		public class IFactoryControls : Il2CppObjectBase
		{
			// Token: 0x06000B3B RID: 2875 RVA: 0x0000611C File Offset: 0x0000431C
			// Note: this type is marked as 'beforefieldinit'.
			static IFactoryControls()
			{
				Il2CppClassPointerStore<DefaultControls.IFactoryControls>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, "IFactoryControls");
				DefaultControls.IFactoryControls.NativeMethodInfoPtr_CreateGameObject_Public_Abstract_Virtual_New_GameObject_String_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls.IFactoryControls>.NativeClassPtr, 100663404);
			}

			// Token: 0x06000B3C RID: 2876 RVA: 0x00031F38 File Offset: 0x00030138
			[CallerCount(0)]
			public unsafe virtual GameObject CreateGameObject(string name, [Optional] Il2CppReferenceArray<Type> components)
			{
				if (components == null)
				{
					components = new Il2CppReferenceArray<Type>(0L);
				}
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(components);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultControls.IFactoryControls.NativeMethodInfoPtr_CreateGameObject_Public_Abstract_Virtual_New_GameObject_String_Il2CppReferenceArray_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}

			// Token: 0x06000B3D RID: 2877 RVA: 0x00006146 File Offset: 0x00004346
			public virtual GameObject CreateGameObject(string name, params Type[] components)
			{
				return this.CreateGameObject(name, new Il2CppReferenceArray<Type>(components));
			}

			// Token: 0x06000B3E RID: 2878 RVA: 0x00006155 File Offset: 0x00004355
			public IFactoryControls(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000876 RID: 2166
			private static readonly IntPtr NativeMethodInfoPtr_CreateGameObject_Public_Abstract_Virtual_New_GameObject_String_Il2CppReferenceArray_1_Type_0;
		}

		// Token: 0x02000077 RID: 119
		public class DefaultRuntimeFactory : Object
		{
			// Token: 0x06000B3F RID: 2879 RVA: 0x00031FB4 File Offset: 0x000301B4
			// Note: this type is marked as 'beforefieldinit'.
			static DefaultRuntimeFactory()
			{
				Il2CppClassPointerStore<DefaultControls.DefaultRuntimeFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, "DefaultRuntimeFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultControls.DefaultRuntimeFactory>.NativeClassPtr);
				DefaultControls.DefaultRuntimeFactory.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls.DefaultRuntimeFactory>.NativeClassPtr, "Default");
				DefaultControls.DefaultRuntimeFactory.NativeMethodInfoPtr_CreateGameObject_Public_Virtual_Final_New_GameObject_String_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls.DefaultRuntimeFactory>.NativeClassPtr, 100663405);
				DefaultControls.DefaultRuntimeFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls.DefaultRuntimeFactory>.NativeClassPtr, 100663406);
			}

			// Token: 0x06000B40 RID: 2880 RVA: 0x0003201C File Offset: 0x0003021C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516292, XrefRangeEnd = 516296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual GameObject CreateGameObject(string name, [Optional] Il2CppReferenceArray<Type> components)
			{
				if (components == null)
				{
					components = new Il2CppReferenceArray<Type>(0L);
				}
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(components);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.DefaultRuntimeFactory.NativeMethodInfoPtr_CreateGameObject_Public_Virtual_Final_New_GameObject_String_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}

			// Token: 0x06000B41 RID: 2881 RVA: 0x0003208C File Offset: 0x0003028C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DefaultRuntimeFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultControls.DefaultRuntimeFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.DefaultRuntimeFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000B42 RID: 2882 RVA: 0x0000615E File Offset: 0x0000435E
			public virtual GameObject CreateGameObject(string name, params Type[] components)
			{
				return this.CreateGameObject(name, new Il2CppReferenceArray<Type>(components));
			}

			// Token: 0x06000B43 RID: 2883 RVA: 0x0000616D File Offset: 0x0000436D
			public DefaultRuntimeFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003C7 RID: 967
			// (get) Token: 0x06000B44 RID: 2884 RVA: 0x000320C8 File Offset: 0x000302C8
			// (set) Token: 0x06000B45 RID: 2885 RVA: 0x00006176 File Offset: 0x00004376
			public unsafe static DefaultControls.IFactoryControls Default
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DefaultControls.DefaultRuntimeFactory.NativeFieldInfoPtr_Default, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DefaultControls.IFactoryControls>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DefaultControls.DefaultRuntimeFactory.NativeFieldInfoPtr_Default, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000877 RID: 2167
			private static readonly IntPtr NativeFieldInfoPtr_Default;

			// Token: 0x04000878 RID: 2168
			private static readonly IntPtr NativeMethodInfoPtr_CreateGameObject_Public_Virtual_Final_New_GameObject_String_Il2CppReferenceArray_1_Type_0;

			// Token: 0x04000879 RID: 2169
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000078 RID: 120
		public sealed class Resources : ValueType
		{
			// Token: 0x06000B46 RID: 2886 RVA: 0x000320F0 File Offset: 0x000302F0
			// Note: this type is marked as 'beforefieldinit'.
			static Resources()
			{
				Il2CppClassPointerStore<DefaultControls.Resources>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, "Resources");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultControls.Resources>.NativeClassPtr);
				DefaultControls.Resources.NativeFieldInfoPtr_standard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls.Resources>.NativeClassPtr, "standard");
				DefaultControls.Resources.NativeFieldInfoPtr_background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls.Resources>.NativeClassPtr, "background");
				DefaultControls.Resources.NativeFieldInfoPtr_inputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls.Resources>.NativeClassPtr, "inputField");
				DefaultControls.Resources.NativeFieldInfoPtr_knob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls.Resources>.NativeClassPtr, "knob");
				DefaultControls.Resources.NativeFieldInfoPtr_checkmark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls.Resources>.NativeClassPtr, "checkmark");
				DefaultControls.Resources.NativeFieldInfoPtr_dropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls.Resources>.NativeClassPtr, "dropdown");
				DefaultControls.Resources.NativeFieldInfoPtr_mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls.Resources>.NativeClassPtr, "mask");
			}

			// Token: 0x06000B47 RID: 2887 RVA: 0x00006188 File Offset: 0x00004388
			public Resources(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000B48 RID: 2888 RVA: 0x00006191 File Offset: 0x00004391
			public Resources()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultControls.Resources>.NativeClassPtr))
			{
			}

			// Token: 0x170003C8 RID: 968
			// (get) Token: 0x06000B49 RID: 2889 RVA: 0x000321A8 File Offset: 0x000303A8
			// (set) Token: 0x06000B4A RID: 2890 RVA: 0x000061A3 File Offset: 0x000043A3
			public unsafe Sprite standard
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultControls.Resources.NativeFieldInfoPtr_standard);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultControls.Resources.NativeFieldInfoPtr_standard), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003C9 RID: 969
			// (get) Token: 0x06000B4B RID: 2891 RVA: 0x000321D8 File Offset: 0x000303D8
			// (set) Token: 0x06000B4C RID: 2892 RVA: 0x000061C2 File Offset: 0x000043C2
			public unsafe Sprite background
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultControls.Resources.NativeFieldInfoPtr_background);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultControls.Resources.NativeFieldInfoPtr_background), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003CA RID: 970
			// (get) Token: 0x06000B4D RID: 2893 RVA: 0x00032208 File Offset: 0x00030408
			// (set) Token: 0x06000B4E RID: 2894 RVA: 0x000061E1 File Offset: 0x000043E1
			public unsafe Sprite inputField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultControls.Resources.NativeFieldInfoPtr_inputField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultControls.Resources.NativeFieldInfoPtr_inputField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003CB RID: 971
			// (get) Token: 0x06000B4F RID: 2895 RVA: 0x00032238 File Offset: 0x00030438
			// (set) Token: 0x06000B50 RID: 2896 RVA: 0x00006200 File Offset: 0x00004400
			public unsafe Sprite knob
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultControls.Resources.NativeFieldInfoPtr_knob);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultControls.Resources.NativeFieldInfoPtr_knob), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003CC RID: 972
			// (get) Token: 0x06000B51 RID: 2897 RVA: 0x00032268 File Offset: 0x00030468
			// (set) Token: 0x06000B52 RID: 2898 RVA: 0x0000621F File Offset: 0x0000441F
			public unsafe Sprite checkmark
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultControls.Resources.NativeFieldInfoPtr_checkmark);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultControls.Resources.NativeFieldInfoPtr_checkmark), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003CD RID: 973
			// (get) Token: 0x06000B53 RID: 2899 RVA: 0x00032298 File Offset: 0x00030498
			// (set) Token: 0x06000B54 RID: 2900 RVA: 0x0000623E File Offset: 0x0000443E
			public unsafe Sprite dropdown
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultControls.Resources.NativeFieldInfoPtr_dropdown);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultControls.Resources.NativeFieldInfoPtr_dropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003CE RID: 974
			// (get) Token: 0x06000B55 RID: 2901 RVA: 0x000322C8 File Offset: 0x000304C8
			// (set) Token: 0x06000B56 RID: 2902 RVA: 0x0000625D File Offset: 0x0000445D
			public unsafe Sprite mask
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultControls.Resources.NativeFieldInfoPtr_mask);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultControls.Resources.NativeFieldInfoPtr_mask), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400087A RID: 2170
			private static readonly IntPtr NativeFieldInfoPtr_standard;

			// Token: 0x0400087B RID: 2171
			private static readonly IntPtr NativeFieldInfoPtr_background;

			// Token: 0x0400087C RID: 2172
			private static readonly IntPtr NativeFieldInfoPtr_inputField;

			// Token: 0x0400087D RID: 2173
			private static readonly IntPtr NativeFieldInfoPtr_knob;

			// Token: 0x0400087E RID: 2174
			private static readonly IntPtr NativeFieldInfoPtr_checkmark;

			// Token: 0x0400087F RID: 2175
			private static readonly IntPtr NativeFieldInfoPtr_dropdown;

			// Token: 0x04000880 RID: 2176
			private static readonly IntPtr NativeFieldInfoPtr_mask;
		}
	}
}
