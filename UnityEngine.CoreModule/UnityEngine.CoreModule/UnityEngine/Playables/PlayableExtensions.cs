using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Playables
{
	// Token: 0x02000188 RID: 392
	public static class PlayableExtensions : Object
	{
		// Token: 0x06001D81 RID: 7553 RVA: 0x0006C3F0 File Offset: 0x0006A5F0
		// Note: this type is marked as 'beforefieldinit'.
		static PlayableExtensions()
		{
			Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "PlayableExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr);
			PlayableExtensions.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100665946);
			PlayableExtensions.NativeMethodInfoPtr_GetGraph_Public_Static_PlayableGraph_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100665947);
			PlayableExtensions.NativeMethodInfoPtr_GetPlayState_Public_Static_PlayState_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100665948);
			PlayableExtensions.NativeMethodInfoPtr_Play_Public_Static_Void_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100665949);
			PlayableExtensions.NativeMethodInfoPtr_Pause_Public_Static_Void_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100665950);
			PlayableExtensions.NativeMethodInfoPtr_SetSpeed_Public_Static_Void_U_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100665951);
			PlayableExtensions.NativeMethodInfoPtr_SetDuration_Public_Static_Void_U_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100665952);
			PlayableExtensions.NativeMethodInfoPtr_GetDuration_Public_Static_Double_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100665953);
			PlayableExtensions.NativeMethodInfoPtr_SetTime_Public_Static_Void_U_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100665954);
			PlayableExtensions.NativeMethodInfoPtr_GetTime_Public_Static_Double_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100665955);
			PlayableExtensions.NativeMethodInfoPtr_GetPreviousTime_Public_Static_Double_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100665956);
			PlayableExtensions.NativeMethodInfoPtr_IsDone_Public_Static_Boolean_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100665957);
			PlayableExtensions.NativeMethodInfoPtr_SetPropagateSetTime_Public_Static_Void_U_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100665958);
			PlayableExtensions.NativeMethodInfoPtr_SetInputCount_Public_Static_Void_U_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100665959);
			PlayableExtensions.NativeMethodInfoPtr_GetInputCount_Public_Static_Int32_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100665960);
			PlayableExtensions.NativeMethodInfoPtr_GetInput_Public_Static_Playable_U_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100665961);
			PlayableExtensions.NativeMethodInfoPtr_SetInputWeight_Public_Static_Void_U_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100665962);
			PlayableExtensions.NativeMethodInfoPtr_SetInputWeight_Public_Static_Void_U_V_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100665963);
			PlayableExtensions.NativeMethodInfoPtr_GetInputWeight_Public_Static_Single_U_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100665964);
			PlayableExtensions.NativeMethodInfoPtr_SetTraversalMode_Public_Static_Void_U_PlayableTraversalMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100665965);
			PlayableExtensions.NativeMethodInfoPtr_GetTimeWrapMode_Internal_Static_DirectorWrapMode_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100665966);
			PlayableExtensions.NativeMethodInfoPtr_SetTimeWrapMode_Internal_Static_Void_U_DirectorWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100665967);
		}

		// Token: 0x06001D82 RID: 7554 RVA: 0x0006C5D8 File Offset: 0x0006A7D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 503455, RefRangeEnd = 503458, XrefRangeStart = 503444, XrefRangeEnd = 503455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValid<U>(this U playable) where U : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref U ptr4;
				if (!typeof(U).IsValueType)
				{
					U u = playable;
					if (!(u is string))
					{
						ref U ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(u as string);
					}
				}
				else
				{
					ptr4 = ref playable;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_IsValid_Public_Static_Boolean_U_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D83 RID: 7555 RVA: 0x0006C664 File Offset: 0x0006A864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503458, XrefRangeEnd = 503463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayableGraph GetGraph<U>(this U playable) where U : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref U ptr4;
				if (!typeof(U).IsValueType)
				{
					U u = playable;
					if (!(u is string))
					{
						ref U ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(u as string);
					}
				}
				else
				{
					ptr4 = ref playable;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_GetGraph_Public_Static_PlayableGraph_U_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D84 RID: 7556 RVA: 0x0006C6F0 File Offset: 0x0006A8F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503463, XrefRangeEnd = 503468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayState GetPlayState<U>(this U playable) where U : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref U ptr4;
				if (!typeof(U).IsValueType)
				{
					U u = playable;
					if (!(u is string))
					{
						ref U ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(u as string);
					}
				}
				else
				{
					ptr4 = ref playable;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_GetPlayState_Public_Static_PlayState_U_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D85 RID: 7557 RVA: 0x0006C77C File Offset: 0x0006A97C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503468, XrefRangeEnd = 503473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Play<U>(this U playable) where U : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref U ptr4;
				if (!typeof(U).IsValueType)
				{
					U u = playable;
					if (!(u is string))
					{
						ref U ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(u as string);
					}
				}
				else
				{
					ptr4 = ref playable;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_Play_Public_Static_Void_U_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D86 RID: 7558 RVA: 0x0006C800 File Offset: 0x0006AA00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503473, XrefRangeEnd = 503478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Pause<U>(this U playable) where U : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref U ptr4;
				if (!typeof(U).IsValueType)
				{
					U u = playable;
					if (!(u is string))
					{
						ref U ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(u as string);
					}
				}
				else
				{
					ptr4 = ref playable;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_Pause_Public_Static_Void_U_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D87 RID: 7559 RVA: 0x0006C884 File Offset: 0x0006AA84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503478, XrefRangeEnd = 503483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetSpeed<U>(this U playable, double value) where U : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref U ptr4;
				if (!typeof(U).IsValueType)
				{
					U u = playable;
					if (!(u is string))
					{
						ref U ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(u as string);
					}
				}
				else
				{
					ptr4 = ref playable;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_SetSpeed_Public_Static_Void_U_Double_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D88 RID: 7560 RVA: 0x0006C914 File Offset: 0x0006AB14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503483, XrefRangeEnd = 503494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetDuration<U>(this U playable, double value) where U : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref U ptr4;
				if (!typeof(U).IsValueType)
				{
					U u = playable;
					if (!(u is string))
					{
						ref U ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(u as string);
					}
				}
				else
				{
					ptr4 = ref playable;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_SetDuration_Public_Static_Void_U_Double_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D89 RID: 7561 RVA: 0x0006C9A4 File Offset: 0x0006ABA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503494, XrefRangeEnd = 503499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double GetDuration<U>(this U playable) where U : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref U ptr4;
				if (!typeof(U).IsValueType)
				{
					U u = playable;
					if (!(u is string))
					{
						ref U ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(u as string);
					}
				}
				else
				{
					ptr4 = ref playable;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_GetDuration_Public_Static_Double_U_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D8A RID: 7562 RVA: 0x0006CA30 File Offset: 0x0006AC30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503499, XrefRangeEnd = 503504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetTime<U>(this U playable, double value) where U : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref U ptr4;
				if (!typeof(U).IsValueType)
				{
					U u = playable;
					if (!(u is string))
					{
						ref U ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(u as string);
					}
				}
				else
				{
					ptr4 = ref playable;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_SetTime_Public_Static_Void_U_Double_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D8B RID: 7563 RVA: 0x0006CAC0 File Offset: 0x0006ACC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503504, XrefRangeEnd = 503509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double GetTime<U>(this U playable) where U : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref U ptr4;
				if (!typeof(U).IsValueType)
				{
					U u = playable;
					if (!(u is string))
					{
						ref U ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(u as string);
					}
				}
				else
				{
					ptr4 = ref playable;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_GetTime_Public_Static_Double_U_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D8C RID: 7564 RVA: 0x0006CB4C File Offset: 0x0006AD4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503509, XrefRangeEnd = 503514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double GetPreviousTime<U>(this U playable) where U : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref U ptr4;
				if (!typeof(U).IsValueType)
				{
					U u = playable;
					if (!(u is string))
					{
						ref U ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(u as string);
					}
				}
				else
				{
					ptr4 = ref playable;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_GetPreviousTime_Public_Static_Double_U_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D8D RID: 7565 RVA: 0x0006CBD8 File Offset: 0x0006ADD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503514, XrefRangeEnd = 503519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDone<U>(this U playable) where U : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref U ptr4;
				if (!typeof(U).IsValueType)
				{
					U u = playable;
					if (!(u is string))
					{
						ref U ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(u as string);
					}
				}
				else
				{
					ptr4 = ref playable;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_IsDone_Public_Static_Boolean_U_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D8E RID: 7566 RVA: 0x0006CC64 File Offset: 0x0006AE64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 503530, RefRangeEnd = 503532, XrefRangeStart = 503519, XrefRangeEnd = 503530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetPropagateSetTime<U>(this U playable, bool value) where U : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref U ptr4;
				if (!typeof(U).IsValueType)
				{
					U u = playable;
					if (!(u is string))
					{
						ref U ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(u as string);
					}
				}
				else
				{
					ptr4 = ref playable;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_SetPropagateSetTime_Public_Static_Void_U_Boolean_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D8F RID: 7567 RVA: 0x0006CCF4 File Offset: 0x0006AEF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503532, XrefRangeEnd = 503543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetInputCount<U>(this U playable, int value) where U : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref U ptr4;
				if (!typeof(U).IsValueType)
				{
					U u = playable;
					if (!(u is string))
					{
						ref U ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(u as string);
					}
				}
				else
				{
					ptr4 = ref playable;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_SetInputCount_Public_Static_Void_U_Int32_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D90 RID: 7568 RVA: 0x0006CD84 File Offset: 0x0006AF84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503543, XrefRangeEnd = 503548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetInputCount<U>(this U playable) where U : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref U ptr4;
				if (!typeof(U).IsValueType)
				{
					U u = playable;
					if (!(u is string))
					{
						ref U ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(u as string);
					}
				}
				else
				{
					ptr4 = ref playable;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_GetInputCount_Public_Static_Int32_U_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D91 RID: 7569 RVA: 0x0006CE10 File Offset: 0x0006B010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503548, XrefRangeEnd = 503553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Playable GetInput<U>(this U playable, int inputPort) where U : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref U ptr4;
				if (!typeof(U).IsValueType)
				{
					U u = playable;
					if (!(u is string))
					{
						ref U ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(u as string);
					}
				}
				else
				{
					ptr4 = ref playable;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputPort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_GetInput_Public_Static_Playable_U_Int32_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D92 RID: 7570 RVA: 0x0006CEAC File Offset: 0x0006B0AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503553, XrefRangeEnd = 503559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetInputWeight<U>(this U playable, int inputIndex, float weight) where U : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref U ptr4;
				if (!typeof(U).IsValueType)
				{
					U u = playable;
					if (!(u is string))
					{
						ref U ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(u as string);
					}
				}
				else
				{
					ptr4 = ref playable;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_SetInputWeight_Public_Static_Void_U_Int32_Single_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D93 RID: 7571 RVA: 0x0006CF4C File Offset: 0x0006B14C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503559, XrefRangeEnd = 503570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetInputWeight<U, V>(this U playable, V input, float weight) where U : new() where V : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref U ptr4;
				if (!typeof(U).IsValueType)
				{
					U u = playable;
					if (!(u is string))
					{
						ref U ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(u as string);
					}
				}
				else
				{
					ptr4 = ref playable;
				}
				*ptr2 = ref ptr4;
			}
			IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref V ptr7;
			if (!typeof(V).IsValueType)
			{
				V v = input;
				if (!(v is string))
				{
					ref V ptr6 = (ptr7 = IL2CPP.Il2CppObjectBaseToPtr(v as Il2CppObjectBase));
					if ((ref ptr6) != null)
					{
						ptr7 = ref ptr6;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr6)))
						{
							ptr7 = IL2CPP.il2cpp_object_unbox(ref ptr6);
						}
					}
				}
				else
				{
					ptr7 = IL2CPP.ManagedStringToIl2Cpp(v as string);
				}
			}
			else
			{
				ptr7 = ref input;
			}
			*ptr5 = ref ptr7;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_SetInputWeight_Public_Static_Void_U_V_Single_0<U, V>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D94 RID: 7572 RVA: 0x0006D038 File Offset: 0x0006B238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503570, XrefRangeEnd = 503571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetInputWeight<U>(this U playable, int inputIndex) where U : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref U ptr4;
				if (!typeof(U).IsValueType)
				{
					U u = playable;
					if (!(u is string))
					{
						ref U ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(u as string);
					}
				}
				else
				{
					ptr4 = ref playable;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_GetInputWeight_Public_Static_Single_U_Int32_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D95 RID: 7573 RVA: 0x0006D0D4 File Offset: 0x0006B2D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503571, XrefRangeEnd = 503582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetTraversalMode<U>(this U playable, PlayableTraversalMode mode) where U : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref U ptr4;
				if (!typeof(U).IsValueType)
				{
					U u = playable;
					if (!(u is string))
					{
						ref U ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(u as string);
					}
				}
				else
				{
					ptr4 = ref playable;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_SetTraversalMode_Public_Static_Void_U_PlayableTraversalMode_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D96 RID: 7574 RVA: 0x0006D164 File Offset: 0x0006B364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503582, XrefRangeEnd = 503587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DirectorWrapMode GetTimeWrapMode<U>(this U playable) where U : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref U ptr4;
				if (!typeof(U).IsValueType)
				{
					U u = playable;
					if (!(u is string))
					{
						ref U ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(u as string);
					}
				}
				else
				{
					ptr4 = ref playable;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_GetTimeWrapMode_Internal_Static_DirectorWrapMode_U_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D97 RID: 7575 RVA: 0x0006D1F0 File Offset: 0x0006B3F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503587, XrefRangeEnd = 503598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetTimeWrapMode<U>(this U playable, DirectorWrapMode value) where U : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref U ptr4;
				if (!typeof(U).IsValueType)
				{
					U u = playable;
					if (!(u is string))
					{
						ref U ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(u as string);
					}
				}
				else
				{
					ptr4 = ref playable;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_SetTimeWrapMode_Internal_Static_Void_U_DirectorWrapMode_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D98 RID: 7576 RVA: 0x0000FBB1 File Offset: 0x0000DDB1
		public PlayableExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001D99 RID: 7577 RVA: 0x0006D280 File Offset: 0x0006B480
		public static bool IsNull<U>(U playable) where U : struct
		{
			return playable.GetHandle().IsNull();
		}

		// Token: 0x06001D9A RID: 7578 RVA: 0x0006D2A8 File Offset: 0x0006B4A8
		public static void Destroy<U>(U playable) where U : struct
		{
			playable.GetHandle().Destroy();
		}

		// Token: 0x06001D9B RID: 7579 RVA: 0x0006D2CC File Offset: 0x0006B4CC
		public static void SetPlayState<U>(U playable, PlayState value) where U : struct
		{
			bool flag = value == PlayState.Delayed;
			if (flag)
			{
				throw new ArgumentException("Can't set Delayed: use SetDelay() instead");
			}
			if (value != PlayState.Paused)
			{
				if (value == PlayState.Playing)
				{
					playable.GetHandle().Play();
				}
			}
			else
			{
				playable.GetHandle().Pause();
			}
		}

		// Token: 0x06001D9C RID: 7580 RVA: 0x0006D32C File Offset: 0x0006B52C
		public static double GetSpeed<U>(U playable) where U : struct
		{
			return playable.GetHandle().GetSpeed();
		}

		// Token: 0x06001D9D RID: 7581 RVA: 0x0006D354 File Offset: 0x0006B554
		public static void SetDone<U>(U playable, bool value) where U : struct
		{
			playable.GetHandle().SetDone(value);
		}

		// Token: 0x06001D9E RID: 7582 RVA: 0x0006D37C File Offset: 0x0006B57C
		public static bool GetPropagateSetTime<U>(U playable) where U : struct
		{
			return playable.GetHandle().GetPropagateSetTime();
		}

		// Token: 0x06001D9F RID: 7583 RVA: 0x0006D3A4 File Offset: 0x0006B5A4
		public static bool CanChangeInputs<U>(U playable) where U : struct
		{
			return playable.GetHandle().CanChangeInputs();
		}

		// Token: 0x06001DA0 RID: 7584 RVA: 0x0006D3CC File Offset: 0x0006B5CC
		public static bool CanSetWeights<U>(U playable) where U : struct
		{
			return playable.GetHandle().CanSetWeights();
		}

		// Token: 0x06001DA1 RID: 7585 RVA: 0x0006D3F4 File Offset: 0x0006B5F4
		public static bool CanDestroy<U>(U playable) where U : struct
		{
			return playable.GetHandle().CanDestroy();
		}

		// Token: 0x06001DA2 RID: 7586 RVA: 0x0006D41C File Offset: 0x0006B61C
		public static void SetOutputCount<U>(U playable, int value) where U : struct
		{
			playable.GetHandle().SetOutputCount(value);
		}

		// Token: 0x06001DA3 RID: 7587 RVA: 0x0006D444 File Offset: 0x0006B644
		public static int GetOutputCount<U>(U playable) where U : struct
		{
			return playable.GetHandle().GetOutputCount();
		}

		// Token: 0x06001DA4 RID: 7588 RVA: 0x0006D46C File Offset: 0x0006B66C
		public static Playable GetOutput<U>(U playable, int outputPort) where U : struct
		{
			return playable.GetHandle().GetOutput(outputPort);
		}

		// Token: 0x06001DA5 RID: 7589 RVA: 0x0000FBBA File Offset: 0x0000DDBA
		public static void ConnectInput<U, V>(U playable, int inputIndex, V sourcePlayable, int sourceOutputIndex) where U : struct where V : struct
		{
			PlayableExtensions.ConnectInput<U, V>(playable, inputIndex, sourcePlayable, sourceOutputIndex, 0f);
		}

		// Token: 0x06001DA6 RID: 7590 RVA: 0x0006D494 File Offset: 0x0006B694
		public static void ConnectInput<U, V>(U playable, int inputIndex, V sourcePlayable, int sourceOutputIndex, float weight) where U : struct where V : struct
		{
			playable.GetGraph<U>().Connect<V, U>(sourcePlayable, sourceOutputIndex, playable, inputIndex);
			playable.SetInputWeight(inputIndex, weight);
		}

		// Token: 0x06001DA7 RID: 7591 RVA: 0x0006D4C0 File Offset: 0x0006B6C0
		public static void DisconnectInput<U>(U playable, int inputPort) where U : struct
		{
			playable.GetGraph<U>().Disconnect<U>(playable, inputPort);
		}

		// Token: 0x06001DA8 RID: 7592 RVA: 0x0006D4E0 File Offset: 0x0006B6E0
		public static int AddInput<U, V>(U playable, V sourcePlayable, int sourceOutputIndex, [Optional] float weight) where U : struct where V : struct
		{
			int inputCount = playable.GetInputCount<U>();
			playable.SetInputCount(inputCount + 1);
			PlayableExtensions.ConnectInput<U, V>(playable, inputCount, sourcePlayable, sourceOutputIndex, weight);
			return inputCount;
		}

		// Token: 0x06001DA9 RID: 7593 RVA: 0x0006D510 File Offset: 0x0006B710
		public static void SetDelay<U>(U playable, double delay) where U : struct
		{
			playable.GetHandle().SetDelay(delay);
		}

		// Token: 0x06001DAA RID: 7594 RVA: 0x0006D538 File Offset: 0x0006B738
		public static double GetDelay<U>(U playable) where U : struct
		{
			return playable.GetHandle().GetDelay();
		}

		// Token: 0x06001DAB RID: 7595 RVA: 0x0006D560 File Offset: 0x0006B760
		public static bool IsDelayed<U>(U playable) where U : struct
		{
			return playable.GetHandle().IsDelayed();
		}

		// Token: 0x06001DAC RID: 7596 RVA: 0x0006D588 File Offset: 0x0006B788
		public static void SetLeadTime<U>(U playable, float value) where U : struct
		{
			playable.GetHandle().SetLeadTime(value);
		}

		// Token: 0x06001DAD RID: 7597 RVA: 0x0006D5B0 File Offset: 0x0006B7B0
		public static float GetLeadTime<U>(U playable) where U : struct
		{
			return playable.GetHandle().GetLeadTime();
		}

		// Token: 0x06001DAE RID: 7598 RVA: 0x0006D5D8 File Offset: 0x0006B7D8
		public static PlayableTraversalMode GetTraversalMode<U>(U playable) where U : struct
		{
			return playable.GetHandle().GetTraversalMode();
		}

		// Token: 0x040016AD RID: 5805
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Static_Boolean_U_0;

		// Token: 0x040016AE RID: 5806
		private static readonly IntPtr NativeMethodInfoPtr_GetGraph_Public_Static_PlayableGraph_U_0;

		// Token: 0x040016AF RID: 5807
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayState_Public_Static_PlayState_U_0;

		// Token: 0x040016B0 RID: 5808
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Static_Void_U_0;

		// Token: 0x040016B1 RID: 5809
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Static_Void_U_0;

		// Token: 0x040016B2 RID: 5810
		private static readonly IntPtr NativeMethodInfoPtr_SetSpeed_Public_Static_Void_U_Double_0;

		// Token: 0x040016B3 RID: 5811
		private static readonly IntPtr NativeMethodInfoPtr_SetDuration_Public_Static_Void_U_Double_0;

		// Token: 0x040016B4 RID: 5812
		private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Public_Static_Double_U_0;

		// Token: 0x040016B5 RID: 5813
		private static readonly IntPtr NativeMethodInfoPtr_SetTime_Public_Static_Void_U_Double_0;

		// Token: 0x040016B6 RID: 5814
		private static readonly IntPtr NativeMethodInfoPtr_GetTime_Public_Static_Double_U_0;

		// Token: 0x040016B7 RID: 5815
		private static readonly IntPtr NativeMethodInfoPtr_GetPreviousTime_Public_Static_Double_U_0;

		// Token: 0x040016B8 RID: 5816
		private static readonly IntPtr NativeMethodInfoPtr_IsDone_Public_Static_Boolean_U_0;

		// Token: 0x040016B9 RID: 5817
		private static readonly IntPtr NativeMethodInfoPtr_SetPropagateSetTime_Public_Static_Void_U_Boolean_0;

		// Token: 0x040016BA RID: 5818
		private static readonly IntPtr NativeMethodInfoPtr_SetInputCount_Public_Static_Void_U_Int32_0;

		// Token: 0x040016BB RID: 5819
		private static readonly IntPtr NativeMethodInfoPtr_GetInputCount_Public_Static_Int32_U_0;

		// Token: 0x040016BC RID: 5820
		private static readonly IntPtr NativeMethodInfoPtr_GetInput_Public_Static_Playable_U_Int32_0;

		// Token: 0x040016BD RID: 5821
		private static readonly IntPtr NativeMethodInfoPtr_SetInputWeight_Public_Static_Void_U_Int32_Single_0;

		// Token: 0x040016BE RID: 5822
		private static readonly IntPtr NativeMethodInfoPtr_SetInputWeight_Public_Static_Void_U_V_Single_0;

		// Token: 0x040016BF RID: 5823
		private static readonly IntPtr NativeMethodInfoPtr_GetInputWeight_Public_Static_Single_U_Int32_0;

		// Token: 0x040016C0 RID: 5824
		private static readonly IntPtr NativeMethodInfoPtr_SetTraversalMode_Public_Static_Void_U_PlayableTraversalMode_0;

		// Token: 0x040016C1 RID: 5825
		private static readonly IntPtr NativeMethodInfoPtr_GetTimeWrapMode_Internal_Static_DirectorWrapMode_U_0;

		// Token: 0x040016C2 RID: 5826
		private static readonly IntPtr NativeMethodInfoPtr_SetTimeWrapMode_Internal_Static_Void_U_DirectorWrapMode_0;

		// Token: 0x020009F7 RID: 2551
		private sealed class MethodInfoStoreGeneric_IsValid_Public_Static_Boolean_U_0<U>
		{
			// Token: 0x04001FDD RID: 8157
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_U_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)) }))));
		}

		// Token: 0x020009F8 RID: 2552
		private sealed class MethodInfoStoreGeneric_GetGraph_Public_Static_PlayableGraph_U_0<U>
		{
			// Token: 0x04001FDE RID: 8158
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_GetGraph_Public_Static_PlayableGraph_U_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)) }))));
		}

		// Token: 0x020009F9 RID: 2553
		private sealed class MethodInfoStoreGeneric_GetPlayState_Public_Static_PlayState_U_0<U>
		{
			// Token: 0x04001FDF RID: 8159
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_GetPlayState_Public_Static_PlayState_U_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)) }))));
		}

		// Token: 0x020009FA RID: 2554
		private sealed class MethodInfoStoreGeneric_Play_Public_Static_Void_U_0<U>
		{
			// Token: 0x04001FE0 RID: 8160
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_Play_Public_Static_Void_U_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)) }))));
		}

		// Token: 0x020009FB RID: 2555
		private sealed class MethodInfoStoreGeneric_Pause_Public_Static_Void_U_0<U>
		{
			// Token: 0x04001FE1 RID: 8161
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_Pause_Public_Static_Void_U_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)) }))));
		}

		// Token: 0x020009FC RID: 2556
		private sealed class MethodInfoStoreGeneric_SetSpeed_Public_Static_Void_U_Double_0<U>
		{
			// Token: 0x04001FE2 RID: 8162
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_SetSpeed_Public_Static_Void_U_Double_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)) }))));
		}

		// Token: 0x020009FD RID: 2557
		private sealed class MethodInfoStoreGeneric_SetDuration_Public_Static_Void_U_Double_0<U>
		{
			// Token: 0x04001FE3 RID: 8163
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_SetDuration_Public_Static_Void_U_Double_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)) }))));
		}

		// Token: 0x020009FE RID: 2558
		private sealed class MethodInfoStoreGeneric_GetDuration_Public_Static_Double_U_0<U>
		{
			// Token: 0x04001FE4 RID: 8164
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_GetDuration_Public_Static_Double_U_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)) }))));
		}

		// Token: 0x020009FF RID: 2559
		private sealed class MethodInfoStoreGeneric_SetTime_Public_Static_Void_U_Double_0<U>
		{
			// Token: 0x04001FE5 RID: 8165
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_SetTime_Public_Static_Void_U_Double_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)) }))));
		}

		// Token: 0x02000A00 RID: 2560
		private sealed class MethodInfoStoreGeneric_GetTime_Public_Static_Double_U_0<U>
		{
			// Token: 0x04001FE6 RID: 8166
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_GetTime_Public_Static_Double_U_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)) }))));
		}

		// Token: 0x02000A01 RID: 2561
		private sealed class MethodInfoStoreGeneric_GetPreviousTime_Public_Static_Double_U_0<U>
		{
			// Token: 0x04001FE7 RID: 8167
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_GetPreviousTime_Public_Static_Double_U_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)) }))));
		}

		// Token: 0x02000A02 RID: 2562
		private sealed class MethodInfoStoreGeneric_IsDone_Public_Static_Boolean_U_0<U>
		{
			// Token: 0x04001FE8 RID: 8168
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_IsDone_Public_Static_Boolean_U_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)) }))));
		}

		// Token: 0x02000A03 RID: 2563
		private sealed class MethodInfoStoreGeneric_SetPropagateSetTime_Public_Static_Void_U_Boolean_0<U>
		{
			// Token: 0x04001FE9 RID: 8169
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_SetPropagateSetTime_Public_Static_Void_U_Boolean_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)) }))));
		}

		// Token: 0x02000A04 RID: 2564
		private sealed class MethodInfoStoreGeneric_SetInputCount_Public_Static_Void_U_Int32_0<U>
		{
			// Token: 0x04001FEA RID: 8170
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_SetInputCount_Public_Static_Void_U_Int32_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)) }))));
		}

		// Token: 0x02000A05 RID: 2565
		private sealed class MethodInfoStoreGeneric_GetInputCount_Public_Static_Int32_U_0<U>
		{
			// Token: 0x04001FEB RID: 8171
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_GetInputCount_Public_Static_Int32_U_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)) }))));
		}

		// Token: 0x02000A06 RID: 2566
		private sealed class MethodInfoStoreGeneric_GetInput_Public_Static_Playable_U_Int32_0<U>
		{
			// Token: 0x04001FEC RID: 8172
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_GetInput_Public_Static_Playable_U_Int32_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)) }))));
		}

		// Token: 0x02000A07 RID: 2567
		private sealed class MethodInfoStoreGeneric_SetInputWeight_Public_Static_Void_U_Int32_Single_0<U>
		{
			// Token: 0x04001FED RID: 8173
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_SetInputWeight_Public_Static_Void_U_Int32_Single_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)) }))));
		}

		// Token: 0x02000A08 RID: 2568
		private sealed class MethodInfoStoreGeneric_SetInputWeight_Public_Static_Void_U_V_Single_0<U, V>
		{
			// Token: 0x04001FEE RID: 8174
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_SetInputWeight_Public_Static_Void_U_V_Single_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000A09 RID: 2569
		private sealed class MethodInfoStoreGeneric_GetInputWeight_Public_Static_Single_U_Int32_0<U>
		{
			// Token: 0x04001FEF RID: 8175
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_GetInputWeight_Public_Static_Single_U_Int32_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)) }))));
		}

		// Token: 0x02000A0A RID: 2570
		private sealed class MethodInfoStoreGeneric_SetTraversalMode_Public_Static_Void_U_PlayableTraversalMode_0<U>
		{
			// Token: 0x04001FF0 RID: 8176
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_SetTraversalMode_Public_Static_Void_U_PlayableTraversalMode_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)) }))));
		}

		// Token: 0x02000A0B RID: 2571
		private sealed class MethodInfoStoreGeneric_GetTimeWrapMode_Internal_Static_DirectorWrapMode_U_0<U>
		{
			// Token: 0x04001FF1 RID: 8177
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_GetTimeWrapMode_Internal_Static_DirectorWrapMode_U_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)) }))));
		}

		// Token: 0x02000A0C RID: 2572
		private sealed class MethodInfoStoreGeneric_SetTimeWrapMode_Internal_Static_Void_U_DirectorWrapMode_0<U>
		{
			// Token: 0x04001FF2 RID: 8178
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_SetTimeWrapMode_Internal_Static_Void_U_DirectorWrapMode_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)) }))));
		}
	}
}
