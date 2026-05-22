using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppRewired.UI.ControlMapper
{
	// Token: 0x02000207 RID: 519
	public static class UITools : global::Il2CppSystem.Object
	{
		// Token: 0x06003F3C RID: 16188 RVA: 0x000EC5CC File Offset: 0x000EA7CC
		// Note: this type is marked as 'beforefieldinit'.
		static UITools()
		{
			Il2CppClassPointerStore<UITools>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", "UITools");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UITools>.NativeClassPtr);
			UITools.NativeMethodInfoPtr_InstantiateGUIObject_Public_Static_GameObject_GameObject_Transform_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITools>.NativeClassPtr, 100669344);
			UITools.NativeMethodInfoPtr_InstantiateGUIObject_Public_Static_GameObject_GameObject_Transform_String_Vector2_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITools>.NativeClassPtr, 100669345);
			UITools.NativeMethodInfoPtr_InstantiateGUIObject_Pre_Private_Static_GameObject_GameObject_Transform_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITools>.NativeClassPtr, 100669346);
			UITools.NativeMethodInfoPtr_GetPointOnRectEdge_Public_Static_Vector3_RectTransform_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITools>.NativeClassPtr, 100669347);
			UITools.NativeMethodInfoPtr_GetWorldSpaceRect_Public_Static_Rect_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITools>.NativeClassPtr, 100669348);
			UITools.NativeMethodInfoPtr_TransformRectTo_Public_Static_Rect_Transform_Transform_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITools>.NativeClassPtr, 100669349);
			UITools.NativeMethodInfoPtr_InvertY_Public_Static_Rect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITools>.NativeClassPtr, 100669350);
			UITools.NativeMethodInfoPtr_SetInteractable_Public_Static_Void_Selectable_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITools>.NativeClassPtr, 100669351);
		}

		// Token: 0x06003F3D RID: 16189 RVA: 0x000EC69C File Offset: 0x000EA89C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 100164, RefRangeEnd = 100169, XrefRangeStart = 100125, XrefRangeEnd = 100164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject InstantiateGUIObject<T>(GameObject prefab, Transform parent, string name) where T : Component
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITools.MethodInfoStoreGeneric_InstantiateGUIObject_Public_Static_GameObject_GameObject_Transform_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06003F3E RID: 16190 RVA: 0x000EC704 File Offset: 0x000EA904
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 100212, RefRangeEnd = 100214, XrefRangeStart = 100169, XrefRangeEnd = 100212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject InstantiateGUIObject<T>(GameObject prefab, Transform parent, string name, Vector2 pivot, Vector2 anchorMin, Vector2 anchorMax, Vector2 anchoredPosition) where T : Component
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pivot;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anchorMin;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anchorMax;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anchoredPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITools.MethodInfoStoreGeneric_InstantiateGUIObject_Public_Static_GameObject_GameObject_Transform_String_Vector2_Vector2_Vector2_Vector2_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06003F3F RID: 16191 RVA: 0x000EC7A4 File Offset: 0x000EA9A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100214, XrefRangeEnd = 100274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject InstantiateGUIObject_Pre<T>(GameObject prefab, Transform parent, string name) where T : Component
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITools.MethodInfoStoreGeneric_InstantiateGUIObject_Pre_Private_Static_GameObject_GameObject_Transform_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06003F40 RID: 16192 RVA: 0x000EC80C File Offset: 0x000EAA0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100274, XrefRangeEnd = 100290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetPointOnRectEdge(RectTransform rectTransform, Vector2 dir)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITools.NativeMethodInfoPtr_GetPointOnRectEdge_Public_Static_Vector3_RectTransform_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003F41 RID: 16193 RVA: 0x000EC85C File Offset: 0x000EAA5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100290, XrefRangeEnd = 100310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect GetWorldSpaceRect(RectTransform rt)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITools.NativeMethodInfoPtr_GetWorldSpaceRect_Public_Static_Rect_RectTransform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003F42 RID: 16194 RVA: 0x000EC8A0 File Offset: 0x000EAAA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100348, RefRangeEnd = 100349, XrefRangeStart = 100310, XrefRangeEnd = 100348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect TransformRectTo(Transform from, Transform to, Rect rect)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(from);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITools.NativeMethodInfoPtr_TransformRectTo_Public_Static_Rect_Transform_Transform_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003F43 RID: 16195 RVA: 0x000EC904 File Offset: 0x000EAB04
		[CallerCount(0)]
		public unsafe static Rect InvertY(Rect rect)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rect;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITools.NativeMethodInfoPtr_InvertY_Public_Static_Rect_Rect_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003F44 RID: 16196 RVA: 0x000EC944 File Offset: 0x000EAB44
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 100366, RefRangeEnd = 100371, XrefRangeStart = 100349, XrefRangeEnd = 100366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetInteractable(Selectable selectable, bool state, bool playTransition)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playTransition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITools.NativeMethodInfoPtr_SetInteractable_Public_Static_Void_Selectable_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F45 RID: 16197 RVA: 0x00026E93 File Offset: 0x00025093
		public UITools(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040026B5 RID: 9909
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateGUIObject_Public_Static_GameObject_GameObject_Transform_String_0;

		// Token: 0x040026B6 RID: 9910
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateGUIObject_Public_Static_GameObject_GameObject_Transform_String_Vector2_Vector2_Vector2_Vector2_0;

		// Token: 0x040026B7 RID: 9911
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateGUIObject_Pre_Private_Static_GameObject_GameObject_Transform_String_0;

		// Token: 0x040026B8 RID: 9912
		private static readonly IntPtr NativeMethodInfoPtr_GetPointOnRectEdge_Public_Static_Vector3_RectTransform_Vector2_0;

		// Token: 0x040026B9 RID: 9913
		private static readonly IntPtr NativeMethodInfoPtr_GetWorldSpaceRect_Public_Static_Rect_RectTransform_0;

		// Token: 0x040026BA RID: 9914
		private static readonly IntPtr NativeMethodInfoPtr_TransformRectTo_Public_Static_Rect_Transform_Transform_Rect_0;

		// Token: 0x040026BB RID: 9915
		private static readonly IntPtr NativeMethodInfoPtr_InvertY_Public_Static_Rect_Rect_0;

		// Token: 0x040026BC RID: 9916
		private static readonly IntPtr NativeMethodInfoPtr_SetInteractable_Public_Static_Void_Selectable_Boolean_Boolean_0;

		// Token: 0x02000398 RID: 920
		private sealed class MethodInfoStoreGeneric_InstantiateGUIObject_Public_Static_GameObject_GameObject_Transform_String_0<T>
		{
			// Token: 0x04003A91 RID: 14993
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UITools.NativeMethodInfoPtr_InstantiateGUIObject_Public_Static_GameObject_GameObject_Transform_String_0, Il2CppClassPointerStore<UITools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000399 RID: 921
		private sealed class MethodInfoStoreGeneric_InstantiateGUIObject_Public_Static_GameObject_GameObject_Transform_String_Vector2_Vector2_Vector2_Vector2_0<T>
		{
			// Token: 0x04003A92 RID: 14994
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UITools.NativeMethodInfoPtr_InstantiateGUIObject_Public_Static_GameObject_GameObject_Transform_String_Vector2_Vector2_Vector2_Vector2_0, Il2CppClassPointerStore<UITools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200039A RID: 922
		private sealed class MethodInfoStoreGeneric_InstantiateGUIObject_Pre_Private_Static_GameObject_GameObject_Transform_String_0<T>
		{
			// Token: 0x04003A93 RID: 14995
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UITools.NativeMethodInfoPtr_InstantiateGUIObject_Pre_Private_Static_GameObject_GameObject_Transform_String_0, Il2CppClassPointerStore<UITools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
