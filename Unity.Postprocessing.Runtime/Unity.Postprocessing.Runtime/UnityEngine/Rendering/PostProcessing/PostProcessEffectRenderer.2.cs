using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000050 RID: 80
	public class PostProcessEffectRenderer<T> : PostProcessEffectRenderer where T : PostProcessEffectSettings
	{
		// Token: 0x06000357 RID: 855 RVA: 0x000103B4 File Offset: 0x0000E5B4
		// Note: this type is marked as 'beforefieldinit'.
		static PostProcessEffectRenderer()
		{
			Il2CppClassPointerStore<PostProcessEffectRenderer<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "PostProcessEffectRenderer`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessEffectRenderer<T>>.NativeClassPtr);
			PostProcessEffectRenderer<T>.NativeFieldInfoPtr__settings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessEffectRenderer<T>>.NativeClassPtr, "<settings>k__BackingField");
			PostProcessEffectRenderer<T>.NativeMethodInfoPtr_get_settings_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessEffectRenderer<T>>.NativeClassPtr, 100663569);
			PostProcessEffectRenderer<T>.NativeMethodInfoPtr_set_settings_Internal_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessEffectRenderer<T>>.NativeClassPtr, 100663570);
			PostProcessEffectRenderer<T>.NativeMethodInfoPtr_SetSettings_Internal_Virtual_Void_PostProcessEffectSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessEffectRenderer<T>>.NativeClassPtr, 100663571);
			PostProcessEffectRenderer<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessEffectRenderer<T>>.NativeClassPtr, 100663572);
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000358 RID: 856 RVA: 0x00010484 File Offset: 0x0000E684
		// (set) Token: 0x06000359 RID: 857 RVA: 0x000104C0 File Offset: 0x0000E6C0
		public unsafe T settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessEffectRenderer<T>.NativeMethodInfoPtr_get_settings_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					IntPtr* ptr2 = ptr;
					ref T ptr4;
					if (!typeof(T).IsValueType)
					{
						T t = value;
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
						ptr4 = ref value;
					}
					*ptr2 = ref ptr4;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessEffectRenderer<T>.NativeMethodInfoPtr_set_settings_Internal_set_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00010550 File Offset: 0x0000E750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 446278, XrefRangeEnd = 446283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetSettings(PostProcessEffectSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PostProcessEffectRenderer<T>.NativeMethodInfoPtr_SetSettings_Internal_Virtual_Void_PostProcessEffectSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600035B RID: 859 RVA: 0x000105A0 File Offset: 0x0000E7A0
		[CallerCount(0)]
		public unsafe PostProcessEffectRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessEffectRenderer<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessEffectRenderer<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00003E29 File Offset: 0x00002029
		public PostProcessEffectRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600035D RID: 861 RVA: 0x000105DC File Offset: 0x0000E7DC
		// (set) Token: 0x0600035E RID: 862 RVA: 0x00010604 File Offset: 0x0000E804
		public unsafe T _settings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessEffectRenderer<T>.NativeFieldInfoPtr__settings_k__BackingField);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessEffectRenderer<T>.NativeFieldInfoPtr__settings_k__BackingField);
				Type typeFromHandle = typeof(T);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeFieldInfoPtr__settings_k__BackingField;

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeMethodInfoPtr_get_settings_Public_get_T_0;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeMethodInfoPtr_set_settings_Internal_set_Void_T_0;

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeMethodInfoPtr_SetSettings_Internal_Virtual_Void_PostProcessEffectSettings_0;

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
