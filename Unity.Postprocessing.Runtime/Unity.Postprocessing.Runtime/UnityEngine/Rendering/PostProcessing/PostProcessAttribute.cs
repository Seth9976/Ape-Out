using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000006 RID: 6
	public sealed class PostProcessAttribute : Attribute
	{
		// Token: 0x06000017 RID: 23 RVA: 0x00006334 File Offset: 0x00004534
		// Note: this type is marked as 'beforefieldinit'.
		static PostProcessAttribute()
		{
			Il2CppClassPointerStore<PostProcessAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "PostProcessAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessAttribute>.NativeClassPtr);
			PostProcessAttribute.NativeFieldInfoPtr_renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessAttribute>.NativeClassPtr, "renderer");
			PostProcessAttribute.NativeFieldInfoPtr_eventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessAttribute>.NativeClassPtr, "eventType");
			PostProcessAttribute.NativeFieldInfoPtr_menuItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessAttribute>.NativeClassPtr, "menuItem");
			PostProcessAttribute.NativeFieldInfoPtr_allowInSceneView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessAttribute>.NativeClassPtr, "allowInSceneView");
			PostProcessAttribute.NativeFieldInfoPtr_builtinEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessAttribute>.NativeClassPtr, "builtinEffect");
			PostProcessAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_PostProcessEvent_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessAttribute>.NativeClassPtr, 100663301);
			PostProcessAttribute.NativeMethodInfoPtr__ctor_Internal_Void_Type_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessAttribute>.NativeClassPtr, 100663302);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000063F0 File Offset: 0x000045F0
		[CallerCount(0)]
		public unsafe PostProcessAttribute(Type renderer, PostProcessEvent eventType, string menuItem, bool allowInSceneView = true)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(menuItem);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowInSceneView;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_PostProcessEvent_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000646C File Offset: 0x0000466C
		[CallerCount(0)]
		public unsafe PostProcessAttribute(Type renderer, string menuItem, bool allowInSceneView = true)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(menuItem);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowInSceneView;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessAttribute.NativeMethodInfoPtr__ctor_Internal_Void_Type_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000020FF File Offset: 0x000002FF
		public PostProcessAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001B RID: 27 RVA: 0x000064D8 File Offset: 0x000046D8
		// (set) Token: 0x0600001C RID: 28 RVA: 0x00002108 File Offset: 0x00000308
		public unsafe Type renderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessAttribute.NativeFieldInfoPtr_renderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessAttribute.NativeFieldInfoPtr_renderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00006508 File Offset: 0x00004708
		// (set) Token: 0x0600001E RID: 30 RVA: 0x00002127 File Offset: 0x00000327
		public unsafe PostProcessEvent eventType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessAttribute.NativeFieldInfoPtr_eventType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessAttribute.NativeFieldInfoPtr_eventType)) = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00006530 File Offset: 0x00004730
		// (set) Token: 0x06000020 RID: 32 RVA: 0x00002142 File Offset: 0x00000342
		public unsafe string menuItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessAttribute.NativeFieldInfoPtr_menuItem);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessAttribute.NativeFieldInfoPtr_menuItem), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00006558 File Offset: 0x00004758
		// (set) Token: 0x06000022 RID: 34 RVA: 0x00002161 File Offset: 0x00000361
		public unsafe bool allowInSceneView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessAttribute.NativeFieldInfoPtr_allowInSceneView);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessAttribute.NativeFieldInfoPtr_allowInSceneView)) = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00006580 File Offset: 0x00004780
		// (set) Token: 0x06000024 RID: 36 RVA: 0x0000217C File Offset: 0x0000037C
		public unsafe bool builtinEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessAttribute.NativeFieldInfoPtr_builtinEffect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessAttribute.NativeFieldInfoPtr_builtinEffect)) = value;
			}
		}

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeFieldInfoPtr_renderer;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeFieldInfoPtr_eventType;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeFieldInfoPtr_menuItem;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeFieldInfoPtr_allowInSceneView;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeFieldInfoPtr_builtinEffect;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_PostProcessEvent_String_Boolean_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_String_Boolean_0;
	}
}
