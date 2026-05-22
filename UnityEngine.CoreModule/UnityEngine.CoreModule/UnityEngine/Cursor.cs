using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200009B RID: 155
	public class Cursor : Object
	{
		// Token: 0x06000E6D RID: 3693 RVA: 0x0003B850 File Offset: 0x00039A50
		// Note: this type is marked as 'beforefieldinit'.
		static Cursor()
		{
			Il2CppClassPointerStore<Cursor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Cursor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cursor>.NativeClassPtr);
			Cursor.NativeMethodInfoPtr_get_visible_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor>.NativeClassPtr, 100664343);
			Cursor.NativeMethodInfoPtr_set_visible_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor>.NativeClassPtr, 100664344);
			Cursor.NativeMethodInfoPtr_get_lockState_Public_Static_get_CursorLockMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor>.NativeClassPtr, 100664345);
			Cursor.NativeMethodInfoPtr_set_lockState_Public_Static_set_Void_CursorLockMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor>.NativeClassPtr, 100664346);
			Cursor.SetCursor_InjectedDelegateField = IL2CPP.ResolveICall<Cursor.SetCursor_InjectedDelegate>("UnityEngine.Cursor::SetCursor_Injected");
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000E6E RID: 3694 RVA: 0x0003B8E0 File Offset: 0x00039AE0
		// (set) Token: 0x06000E6F RID: 3695 RVA: 0x0003B910 File Offset: 0x00039B10
		public unsafe static bool visible
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491378, XrefRangeEnd = 491382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cursor.NativeMethodInfoPtr_get_visible_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491382, XrefRangeEnd = 491386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cursor.NativeMethodInfoPtr_set_visible_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000E70 RID: 3696 RVA: 0x0003B944 File Offset: 0x00039B44
		// (set) Token: 0x06000E71 RID: 3697 RVA: 0x0003B974 File Offset: 0x00039B74
		public unsafe static CursorLockMode lockState
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491386, XrefRangeEnd = 491390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cursor.NativeMethodInfoPtr_get_lockState_Public_Static_get_CursorLockMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491390, XrefRangeEnd = 491394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cursor.NativeMethodInfoPtr_set_lockState_Public_Static_set_Void_CursorLockMode_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x00009A08 File Offset: 0x00007C08
		public Cursor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x00009A11 File Offset: 0x00007C11
		public static void SetCursor(Texture2D texture, CursorMode cursorMode)
		{
			Cursor.SetCursor(texture, Vector2.zero, cursorMode);
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x00009A21 File Offset: 0x00007C21
		public static void SetCursor(Texture2D texture, Vector2 hotspot, CursorMode cursorMode)
		{
			Cursor.SetCursor_Injected(texture, ref hotspot, cursorMode);
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x00009A2C File Offset: 0x00007C2C
		public static void SetCursor_Injected(Texture2D texture, ref Vector2 hotspot, CursorMode cursorMode)
		{
			Cursor.SetCursor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(texture), ref hotspot, cursorMode);
		}

		// Token: 0x04000AB0 RID: 2736
		private static readonly IntPtr NativeMethodInfoPtr_get_visible_Public_Static_get_Boolean_0;

		// Token: 0x04000AB1 RID: 2737
		private static readonly IntPtr NativeMethodInfoPtr_set_visible_Public_Static_set_Void_Boolean_0;

		// Token: 0x04000AB2 RID: 2738
		private static readonly IntPtr NativeMethodInfoPtr_get_lockState_Public_Static_get_CursorLockMode_0;

		// Token: 0x04000AB3 RID: 2739
		private static readonly IntPtr NativeMethodInfoPtr_set_lockState_Public_Static_set_Void_CursorLockMode_0;

		// Token: 0x04000AB4 RID: 2740
		private static readonly Cursor.SetCursor_InjectedDelegate SetCursor_InjectedDelegateField;

		// Token: 0x02000760 RID: 1888
		// (Invoke) Token: 0x06002CDD RID: 11485
		private delegate void SetCursor_InjectedDelegate(IntPtr texture, IntPtr hotspot, CursorMode cursorMode);
	}
}
