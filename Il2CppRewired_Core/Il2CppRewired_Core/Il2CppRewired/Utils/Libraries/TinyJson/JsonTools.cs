using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Il2CppRewired.Utils.Libraries.TinyJson
{
	// Token: 0x020001DC RID: 476
	public static class JsonTools : Object
	{
		// Token: 0x060030E6 RID: 12518 RVA: 0x00011946 File Offset: 0x0000FB46
		// Note: this type is marked as 'beforefieldinit'.
		static JsonTools()
		{
			Il2CppClassPointerStore<JsonTools>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Libraries.TinyJson", "JsonTools");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTools>.NativeClassPtr);
			JsonTools.NativeMethodInfoPtr_Clone_Public_Static_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTools>.NativeClassPtr, 100675751);
		}

		// Token: 0x060030E7 RID: 12519 RVA: 0x000F3200 File Offset: 0x000F1400
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 335731, RefRangeEnd = 335734, XrefRangeStart = 335727, XrefRangeEnd = 335731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Clone<T>(T obj) where T : class
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = obj;
					if (!(t is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref obj;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTools.MethodInfoStoreGeneric_Clone_Public_Static_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060030E8 RID: 12520 RVA: 0x0001197F File Offset: 0x0000FB7F
		public JsonTools(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040029B4 RID: 10676
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Static_T_T_0;

		// Token: 0x020003F6 RID: 1014
		private sealed class MethodInfoStoreGeneric_Clone_Public_Static_T_T_0<T>
		{
			// Token: 0x04004329 RID: 17193
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JsonTools.NativeMethodInfoPtr_Clone_Public_Static_T_T_0, Il2CppClassPointerStore<JsonTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
