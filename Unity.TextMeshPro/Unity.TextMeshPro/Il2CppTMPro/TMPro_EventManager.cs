using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppTMPro
{
	// Token: 0x02000060 RID: 96
	public static class TMPro_EventManager : global::Il2CppSystem.Object
	{
		// Token: 0x06000BF6 RID: 3062 RVA: 0x00032E24 File Offset: 0x00031024
		// Note: this type is marked as 'beforefieldinit'.
		static TMPro_EventManager()
		{
			Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMPro_EventManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr);
			TMPro_EventManager.NativeFieldInfoPtr_COMPUTE_DT_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "COMPUTE_DT_EVENT");
			TMPro_EventManager.NativeFieldInfoPtr_MATERIAL_PROPERTY_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "MATERIAL_PROPERTY_EVENT");
			TMPro_EventManager.NativeFieldInfoPtr_FONT_PROPERTY_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "FONT_PROPERTY_EVENT");
			TMPro_EventManager.NativeFieldInfoPtr_SPRITE_ASSET_PROPERTY_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "SPRITE_ASSET_PROPERTY_EVENT");
			TMPro_EventManager.NativeFieldInfoPtr_TEXTMESHPRO_PROPERTY_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "TEXTMESHPRO_PROPERTY_EVENT");
			TMPro_EventManager.NativeFieldInfoPtr_DRAG_AND_DROP_MATERIAL_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "DRAG_AND_DROP_MATERIAL_EVENT");
			TMPro_EventManager.NativeFieldInfoPtr_TEXT_STYLE_PROPERTY_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "TEXT_STYLE_PROPERTY_EVENT");
			TMPro_EventManager.NativeFieldInfoPtr_COLOR_GRADIENT_PROPERTY_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "COLOR_GRADIENT_PROPERTY_EVENT");
			TMPro_EventManager.NativeFieldInfoPtr_TMP_SETTINGS_PROPERTY_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "TMP_SETTINGS_PROPERTY_EVENT");
			TMPro_EventManager.NativeFieldInfoPtr_RESOURCE_LOAD_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "RESOURCE_LOAD_EVENT");
			TMPro_EventManager.NativeFieldInfoPtr_TEXTMESHPRO_UGUI_PROPERTY_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "TEXTMESHPRO_UGUI_PROPERTY_EVENT");
			TMPro_EventManager.NativeFieldInfoPtr_TEXT_CHANGED_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "TEXT_CHANGED_EVENT");
			TMPro_EventManager.NativeMethodInfoPtr_ON_MATERIAL_PROPERTY_CHANGED_Public_Static_Void_Boolean_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100664670);
			TMPro_EventManager.NativeMethodInfoPtr_ON_FONT_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100664671);
			TMPro_EventManager.NativeMethodInfoPtr_ON_SPRITE_ASSET_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100664672);
			TMPro_EventManager.NativeMethodInfoPtr_ON_TEXTMESHPRO_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100664673);
			TMPro_EventManager.NativeMethodInfoPtr_ON_DRAG_AND_DROP_MATERIAL_CHANGED_Public_Static_Void_GameObject_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100664674);
			TMPro_EventManager.NativeMethodInfoPtr_ON_TEXT_STYLE_PROPERTY_CHANGED_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100664675);
			TMPro_EventManager.NativeMethodInfoPtr_ON_COLOR_GRADIENT_PROPERTY_CHANGED_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100664676);
			TMPro_EventManager.NativeMethodInfoPtr_ON_TEXT_CHANGED_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100664677);
			TMPro_EventManager.NativeMethodInfoPtr_ON_TMP_SETTINGS_CHANGED_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100664678);
			TMPro_EventManager.NativeMethodInfoPtr_ON_RESOURCES_LOADED_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100664679);
			TMPro_EventManager.NativeMethodInfoPtr_ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100664680);
			TMPro_EventManager.NativeMethodInfoPtr_ON_COMPUTE_DT_EVENT_Public_Static_Void_Object_Compute_DT_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100664681);
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x00033034 File Offset: 0x00031234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464321, XrefRangeEnd = 464329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ON_MATERIAL_PROPERTY_CHANGED(bool isChanged, Material mat)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isChanged;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mat);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_EventManager.NativeMethodInfoPtr_ON_MATERIAL_PROPERTY_CHANGED_Public_Static_Void_Boolean_Material_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x00033078 File Offset: 0x00031278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464329, XrefRangeEnd = 464337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ON_FONT_PROPERTY_CHANGED(bool isChanged, global::UnityEngine.Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isChanged;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_EventManager.NativeMethodInfoPtr_ON_FONT_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x000330BC File Offset: 0x000312BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464337, XrefRangeEnd = 464345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ON_SPRITE_ASSET_PROPERTY_CHANGED(bool isChanged, global::UnityEngine.Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isChanged;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_EventManager.NativeMethodInfoPtr_ON_SPRITE_ASSET_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x00033100 File Offset: 0x00031300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464345, XrefRangeEnd = 464353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ON_TEXTMESHPRO_PROPERTY_CHANGED(bool isChanged, global::UnityEngine.Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isChanged;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_EventManager.NativeMethodInfoPtr_ON_TEXTMESHPRO_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x00033144 File Offset: 0x00031344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464353, XrefRangeEnd = 464359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ON_DRAG_AND_DROP_MATERIAL_CHANGED(GameObject sender, Material currentMaterial, Material newMaterial)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentMaterial);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newMaterial);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_EventManager.NativeMethodInfoPtr_ON_DRAG_AND_DROP_MATERIAL_CHANGED_Public_Static_Void_GameObject_Material_Material_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x000331A0 File Offset: 0x000313A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464359, XrefRangeEnd = 464365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ON_TEXT_STYLE_PROPERTY_CHANGED(bool isChanged)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isChanged;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_EventManager.NativeMethodInfoPtr_ON_TEXT_STYLE_PROPERTY_CHANGED_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x000331D4 File Offset: 0x000313D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464365, XrefRangeEnd = 464372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ON_COLOR_GRADIENT_PROPERTY_CHANGED(global::UnityEngine.Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_EventManager.NativeMethodInfoPtr_ON_COLOR_GRADIENT_PROPERTY_CHANGED_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x0003320C File Offset: 0x0003140C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464372, XrefRangeEnd = 464379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ON_TEXT_CHANGED(global::UnityEngine.Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_EventManager.NativeMethodInfoPtr_ON_TEXT_CHANGED_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x00033244 File Offset: 0x00031444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464379, XrefRangeEnd = 464385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ON_TMP_SETTINGS_CHANGED()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_EventManager.NativeMethodInfoPtr_ON_TMP_SETTINGS_CHANGED_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x0003326C File Offset: 0x0003146C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464385, XrefRangeEnd = 464391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ON_RESOURCES_LOADED()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_EventManager.NativeMethodInfoPtr_ON_RESOURCES_LOADED_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x00033294 File Offset: 0x00031494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464391, XrefRangeEnd = 464399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED(bool isChanged, global::UnityEngine.Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isChanged;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_EventManager.NativeMethodInfoPtr_ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x000332D8 File Offset: 0x000314D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464399, XrefRangeEnd = 464405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ON_COMPUTE_DT_EVENT(global::Il2CppSystem.Object Sender, Compute_DT_EventArgs e)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_EventManager.NativeMethodInfoPtr_ON_COMPUTE_DT_EVENT_Public_Static_Void_Object_Compute_DT_EventArgs_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x0000790C File Offset: 0x00005B0C
		public TMPro_EventManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06000C04 RID: 3076 RVA: 0x00033320 File Offset: 0x00031520
		// (set) Token: 0x06000C05 RID: 3077 RVA: 0x00007915 File Offset: 0x00005B15
		public unsafe static FastAction<global::Il2CppSystem.Object, Compute_DT_EventArgs> COMPUTE_DT_EVENT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMPro_EventManager.NativeFieldInfoPtr_COMPUTE_DT_EVENT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastAction<global::Il2CppSystem.Object, Compute_DT_EventArgs>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMPro_EventManager.NativeFieldInfoPtr_COMPUTE_DT_EVENT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000C06 RID: 3078 RVA: 0x00033348 File Offset: 0x00031548
		// (set) Token: 0x06000C07 RID: 3079 RVA: 0x00007927 File Offset: 0x00005B27
		public unsafe static FastAction<bool, Material> MATERIAL_PROPERTY_EVENT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMPro_EventManager.NativeFieldInfoPtr_MATERIAL_PROPERTY_EVENT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastAction<bool, Material>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMPro_EventManager.NativeFieldInfoPtr_MATERIAL_PROPERTY_EVENT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000C08 RID: 3080 RVA: 0x00033370 File Offset: 0x00031570
		// (set) Token: 0x06000C09 RID: 3081 RVA: 0x00007939 File Offset: 0x00005B39
		public unsafe static FastAction<bool, global::UnityEngine.Object> FONT_PROPERTY_EVENT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMPro_EventManager.NativeFieldInfoPtr_FONT_PROPERTY_EVENT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastAction<bool, global::UnityEngine.Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMPro_EventManager.NativeFieldInfoPtr_FONT_PROPERTY_EVENT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000C0A RID: 3082 RVA: 0x00033398 File Offset: 0x00031598
		// (set) Token: 0x06000C0B RID: 3083 RVA: 0x0000794B File Offset: 0x00005B4B
		public unsafe static FastAction<bool, global::UnityEngine.Object> SPRITE_ASSET_PROPERTY_EVENT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMPro_EventManager.NativeFieldInfoPtr_SPRITE_ASSET_PROPERTY_EVENT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastAction<bool, global::UnityEngine.Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMPro_EventManager.NativeFieldInfoPtr_SPRITE_ASSET_PROPERTY_EVENT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000C0C RID: 3084 RVA: 0x000333C0 File Offset: 0x000315C0
		// (set) Token: 0x06000C0D RID: 3085 RVA: 0x0000795D File Offset: 0x00005B5D
		public unsafe static FastAction<bool, global::UnityEngine.Object> TEXTMESHPRO_PROPERTY_EVENT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMPro_EventManager.NativeFieldInfoPtr_TEXTMESHPRO_PROPERTY_EVENT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastAction<bool, global::UnityEngine.Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMPro_EventManager.NativeFieldInfoPtr_TEXTMESHPRO_PROPERTY_EVENT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000C0E RID: 3086 RVA: 0x000333E8 File Offset: 0x000315E8
		// (set) Token: 0x06000C0F RID: 3087 RVA: 0x0000796F File Offset: 0x00005B6F
		public unsafe static FastAction<GameObject, Material, Material> DRAG_AND_DROP_MATERIAL_EVENT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMPro_EventManager.NativeFieldInfoPtr_DRAG_AND_DROP_MATERIAL_EVENT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastAction<GameObject, Material, Material>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMPro_EventManager.NativeFieldInfoPtr_DRAG_AND_DROP_MATERIAL_EVENT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000C10 RID: 3088 RVA: 0x00033410 File Offset: 0x00031610
		// (set) Token: 0x06000C11 RID: 3089 RVA: 0x00007981 File Offset: 0x00005B81
		public unsafe static FastAction<bool> TEXT_STYLE_PROPERTY_EVENT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMPro_EventManager.NativeFieldInfoPtr_TEXT_STYLE_PROPERTY_EVENT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastAction<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMPro_EventManager.NativeFieldInfoPtr_TEXT_STYLE_PROPERTY_EVENT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000C12 RID: 3090 RVA: 0x00033438 File Offset: 0x00031638
		// (set) Token: 0x06000C13 RID: 3091 RVA: 0x00007993 File Offset: 0x00005B93
		public unsafe static FastAction<global::UnityEngine.Object> COLOR_GRADIENT_PROPERTY_EVENT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMPro_EventManager.NativeFieldInfoPtr_COLOR_GRADIENT_PROPERTY_EVENT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastAction<global::UnityEngine.Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMPro_EventManager.NativeFieldInfoPtr_COLOR_GRADIENT_PROPERTY_EVENT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06000C14 RID: 3092 RVA: 0x00033460 File Offset: 0x00031660
		// (set) Token: 0x06000C15 RID: 3093 RVA: 0x000079A5 File Offset: 0x00005BA5
		public unsafe static FastAction TMP_SETTINGS_PROPERTY_EVENT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMPro_EventManager.NativeFieldInfoPtr_TMP_SETTINGS_PROPERTY_EVENT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastAction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMPro_EventManager.NativeFieldInfoPtr_TMP_SETTINGS_PROPERTY_EVENT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06000C16 RID: 3094 RVA: 0x00033488 File Offset: 0x00031688
		// (set) Token: 0x06000C17 RID: 3095 RVA: 0x000079B7 File Offset: 0x00005BB7
		public unsafe static FastAction RESOURCE_LOAD_EVENT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMPro_EventManager.NativeFieldInfoPtr_RESOURCE_LOAD_EVENT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastAction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMPro_EventManager.NativeFieldInfoPtr_RESOURCE_LOAD_EVENT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06000C18 RID: 3096 RVA: 0x000334B0 File Offset: 0x000316B0
		// (set) Token: 0x06000C19 RID: 3097 RVA: 0x000079C9 File Offset: 0x00005BC9
		public unsafe static FastAction<bool, global::UnityEngine.Object> TEXTMESHPRO_UGUI_PROPERTY_EVENT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMPro_EventManager.NativeFieldInfoPtr_TEXTMESHPRO_UGUI_PROPERTY_EVENT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastAction<bool, global::UnityEngine.Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMPro_EventManager.NativeFieldInfoPtr_TEXTMESHPRO_UGUI_PROPERTY_EVENT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000C1A RID: 3098 RVA: 0x000334D8 File Offset: 0x000316D8
		// (set) Token: 0x06000C1B RID: 3099 RVA: 0x000079DB File Offset: 0x00005BDB
		public unsafe static FastAction<global::UnityEngine.Object> TEXT_CHANGED_EVENT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMPro_EventManager.NativeFieldInfoPtr_TEXT_CHANGED_EVENT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastAction<global::UnityEngine.Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMPro_EventManager.NativeFieldInfoPtr_TEXT_CHANGED_EVENT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000994 RID: 2452
		private static readonly IntPtr NativeFieldInfoPtr_COMPUTE_DT_EVENT;

		// Token: 0x04000995 RID: 2453
		private static readonly IntPtr NativeFieldInfoPtr_MATERIAL_PROPERTY_EVENT;

		// Token: 0x04000996 RID: 2454
		private static readonly IntPtr NativeFieldInfoPtr_FONT_PROPERTY_EVENT;

		// Token: 0x04000997 RID: 2455
		private static readonly IntPtr NativeFieldInfoPtr_SPRITE_ASSET_PROPERTY_EVENT;

		// Token: 0x04000998 RID: 2456
		private static readonly IntPtr NativeFieldInfoPtr_TEXTMESHPRO_PROPERTY_EVENT;

		// Token: 0x04000999 RID: 2457
		private static readonly IntPtr NativeFieldInfoPtr_DRAG_AND_DROP_MATERIAL_EVENT;

		// Token: 0x0400099A RID: 2458
		private static readonly IntPtr NativeFieldInfoPtr_TEXT_STYLE_PROPERTY_EVENT;

		// Token: 0x0400099B RID: 2459
		private static readonly IntPtr NativeFieldInfoPtr_COLOR_GRADIENT_PROPERTY_EVENT;

		// Token: 0x0400099C RID: 2460
		private static readonly IntPtr NativeFieldInfoPtr_TMP_SETTINGS_PROPERTY_EVENT;

		// Token: 0x0400099D RID: 2461
		private static readonly IntPtr NativeFieldInfoPtr_RESOURCE_LOAD_EVENT;

		// Token: 0x0400099E RID: 2462
		private static readonly IntPtr NativeFieldInfoPtr_TEXTMESHPRO_UGUI_PROPERTY_EVENT;

		// Token: 0x0400099F RID: 2463
		private static readonly IntPtr NativeFieldInfoPtr_TEXT_CHANGED_EVENT;

		// Token: 0x040009A0 RID: 2464
		private static readonly IntPtr NativeMethodInfoPtr_ON_MATERIAL_PROPERTY_CHANGED_Public_Static_Void_Boolean_Material_0;

		// Token: 0x040009A1 RID: 2465
		private static readonly IntPtr NativeMethodInfoPtr_ON_FONT_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0;

		// Token: 0x040009A2 RID: 2466
		private static readonly IntPtr NativeMethodInfoPtr_ON_SPRITE_ASSET_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0;

		// Token: 0x040009A3 RID: 2467
		private static readonly IntPtr NativeMethodInfoPtr_ON_TEXTMESHPRO_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0;

		// Token: 0x040009A4 RID: 2468
		private static readonly IntPtr NativeMethodInfoPtr_ON_DRAG_AND_DROP_MATERIAL_CHANGED_Public_Static_Void_GameObject_Material_Material_0;

		// Token: 0x040009A5 RID: 2469
		private static readonly IntPtr NativeMethodInfoPtr_ON_TEXT_STYLE_PROPERTY_CHANGED_Public_Static_Void_Boolean_0;

		// Token: 0x040009A6 RID: 2470
		private static readonly IntPtr NativeMethodInfoPtr_ON_COLOR_GRADIENT_PROPERTY_CHANGED_Public_Static_Void_Object_0;

		// Token: 0x040009A7 RID: 2471
		private static readonly IntPtr NativeMethodInfoPtr_ON_TEXT_CHANGED_Public_Static_Void_Object_0;

		// Token: 0x040009A8 RID: 2472
		private static readonly IntPtr NativeMethodInfoPtr_ON_TMP_SETTINGS_CHANGED_Public_Static_Void_0;

		// Token: 0x040009A9 RID: 2473
		private static readonly IntPtr NativeMethodInfoPtr_ON_RESOURCES_LOADED_Public_Static_Void_0;

		// Token: 0x040009AA RID: 2474
		private static readonly IntPtr NativeMethodInfoPtr_ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0;

		// Token: 0x040009AB RID: 2475
		private static readonly IntPtr NativeMethodInfoPtr_ON_COMPUTE_DT_EVENT_Public_Static_Void_Object_Compute_DT_EventArgs_0;
	}
}
