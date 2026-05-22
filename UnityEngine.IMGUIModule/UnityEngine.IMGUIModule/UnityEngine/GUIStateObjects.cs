using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000010 RID: 16
	public class GUIStateObjects : Object
	{
		// Token: 0x06000346 RID: 838 RVA: 0x0000E418 File Offset: 0x0000C618
		// Note: this type is marked as 'beforefieldinit'.
		static GUIStateObjects()
		{
			Il2CppClassPointerStore<GUIStateObjects>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUIStateObjects");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUIStateObjects>.NativeClassPtr);
			GUIStateObjects.NativeFieldInfoPtr_s_StateCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStateObjects>.NativeClassPtr, "s_StateCache");
			GUIStateObjects.NativeMethodInfoPtr_GetStateObject_Internal_Static_Object_Type_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStateObjects>.NativeClassPtr, 100663567);
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0000E470 File Offset: 0x0000C670
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 508677, RefRangeEnd = 508681, XrefRangeStart = 508663, XrefRangeEnd = 508677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetStateObject(Type t, int controlID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controlID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStateObjects.NativeMethodInfoPtr_GetStateObject_Internal_Static_Object_Type_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000348 RID: 840 RVA: 0x000034AD File Offset: 0x000016AD
		public GUIStateObjects(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000349 RID: 841 RVA: 0x0000E4C4 File Offset: 0x0000C6C4
		// (set) Token: 0x0600034A RID: 842 RVA: 0x000034B6 File Offset: 0x000016B6
		public unsafe static Dictionary<int, Object> s_StateCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUIStateObjects.NativeFieldInfoPtr_s_StateCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIStateObjects.NativeFieldInfoPtr_s_StateCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0000E4EC File Offset: 0x0000C6EC
		public static Object QueryStateObject(Type t, int controlID)
		{
			Object @object = GUIStateObjects.s_StateCache[controlID];
			bool flag = t.IsInstanceOfType(@object);
			Object object2;
			if (flag)
			{
				object2 = @object;
			}
			else
			{
				object2 = null;
			}
			return object2;
		}

		// Token: 0x0600034C RID: 844 RVA: 0x000034C8 File Offset: 0x000016C8
		public static void Tests_ClearObjects()
		{
			GUIStateObjects.s_StateCache.Clear();
		}

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeFieldInfoPtr_s_StateCache;

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeMethodInfoPtr_GetStateObject_Internal_Static_Object_Type_Int32_0;
	}
}
