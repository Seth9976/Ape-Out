using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x0200005B RID: 91
	public static class CustomRenderTextureManager : Object
	{
		// Token: 0x06000564 RID: 1380 RVA: 0x0002363C File Offset: 0x0002183C
		// Note: this type is marked as 'beforefieldinit'.
		static CustomRenderTextureManager()
		{
			Il2CppClassPointerStore<CustomRenderTextureManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "CustomRenderTextureManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomRenderTextureManager>.NativeClassPtr);
			CustomRenderTextureManager.NativeFieldInfoPtr_textureLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomRenderTextureManager>.NativeClassPtr, "textureLoaded");
			CustomRenderTextureManager.NativeFieldInfoPtr_textureUnloaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomRenderTextureManager>.NativeClassPtr, "textureUnloaded");
			CustomRenderTextureManager.NativeMethodInfoPtr_InvokeOnTextureLoaded_Internal_Private_Static_Void_CustomRenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomRenderTextureManager>.NativeClassPtr, 100663755);
			CustomRenderTextureManager.NativeMethodInfoPtr_InvokeOnTextureUnloaded_Internal_Private_Static_Void_CustomRenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomRenderTextureManager>.NativeClassPtr, 100663756);
			CustomRenderTextureManager.GetAllCustomRenderTexturesDelegateField = IL2CPP.ResolveICall<CustomRenderTextureManager.GetAllCustomRenderTexturesDelegate>("UnityEngine.CustomRenderTextureManager::GetAllCustomRenderTextures");
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x000236CC File Offset: 0x000218CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487752, XrefRangeEnd = 487757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnTextureLoaded_Internal(CustomRenderTexture source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomRenderTextureManager.NativeMethodInfoPtr_InvokeOnTextureLoaded_Internal_Private_Static_Void_CustomRenderTexture_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00023704 File Offset: 0x00021904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487757, XrefRangeEnd = 487762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnTextureUnloaded_Internal(CustomRenderTexture source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomRenderTextureManager.NativeMethodInfoPtr_InvokeOnTextureUnloaded_Internal_Private_Static_Void_CustomRenderTexture_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00004C0B File Offset: 0x00002E0B
		public CustomRenderTextureManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000568 RID: 1384 RVA: 0x0002373C File Offset: 0x0002193C
		// (set) Token: 0x06000569 RID: 1385 RVA: 0x00004C14 File Offset: 0x00002E14
		public unsafe static Action<CustomRenderTexture> textureLoaded
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CustomRenderTextureManager.NativeFieldInfoPtr_textureLoaded, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<CustomRenderTexture>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CustomRenderTextureManager.NativeFieldInfoPtr_textureLoaded, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x00023764 File Offset: 0x00021964
		// (set) Token: 0x0600056B RID: 1387 RVA: 0x00004C26 File Offset: 0x00002E26
		public unsafe static Action<CustomRenderTexture> textureUnloaded
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CustomRenderTextureManager.NativeFieldInfoPtr_textureUnloaded, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<CustomRenderTexture>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CustomRenderTextureManager.NativeFieldInfoPtr_textureUnloaded, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00004C38 File Offset: 0x00002E38
		public static void add_textureLoaded(Action<CustomRenderTexture> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00004C45 File Offset: 0x00002E45
		public static void remove_textureLoaded(Action<CustomRenderTexture> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00004C52 File Offset: 0x00002E52
		public static void add_textureUnloaded(Action<CustomRenderTexture> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00004C5F File Offset: 0x00002E5F
		public static void remove_textureUnloaded(Action<CustomRenderTexture> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00004C6C File Offset: 0x00002E6C
		public static void GetAllCustomRenderTextures(List<CustomRenderTexture> currentCustomRenderTextures)
		{
			CustomRenderTextureManager.GetAllCustomRenderTexturesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(currentCustomRenderTextures));
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00004C7E File Offset: 0x00002E7E
		public static void InvokeTriggerUpdate(CustomRenderTexture crt, int updateCount)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00004C8B File Offset: 0x00002E8B
		public static void add_initializeTriggered(Action<CustomRenderTexture> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00004C98 File Offset: 0x00002E98
		public static void remove_initializeTriggered(Action<CustomRenderTexture> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00004CA5 File Offset: 0x00002EA5
		public static void InvokeTriggerInitialize(CustomRenderTexture crt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0400040B RID: 1035
		private static readonly IntPtr NativeFieldInfoPtr_textureLoaded;

		// Token: 0x0400040C RID: 1036
		private static readonly IntPtr NativeFieldInfoPtr_textureUnloaded;

		// Token: 0x0400040D RID: 1037
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnTextureLoaded_Internal_Private_Static_Void_CustomRenderTexture_0;

		// Token: 0x0400040E RID: 1038
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnTextureUnloaded_Internal_Private_Static_Void_CustomRenderTexture_0;

		// Token: 0x0400040F RID: 1039
		private static readonly CustomRenderTextureManager.GetAllCustomRenderTexturesDelegate GetAllCustomRenderTexturesDelegateField;

		// Token: 0x02000431 RID: 1073
		// (Invoke) Token: 0x06002691 RID: 9873
		private delegate void GetAllCustomRenderTexturesDelegate(IntPtr currentCustomRenderTextures);
	}
}
