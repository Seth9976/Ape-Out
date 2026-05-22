using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Playables
{
	// Token: 0x0200018F RID: 399
	public sealed class ScriptPlayable<T> : ValueType where T : class, new()
	{
		// Token: 0x06001EA5 RID: 7845 RVA: 0x00070904 File Offset: 0x0006EB04
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptPlayable()
		{
			Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "ScriptPlayable`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr);
			ScriptPlayable<T>.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, "m_Handle");
			ScriptPlayable<T>.NativeFieldInfoPtr_m_NullPlayable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, "m_NullPlayable");
			ScriptPlayable<T>.NativeMethodInfoPtr_get_Null_Public_Static_get_ScriptPlayable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, 100666094);
			ScriptPlayable<T>.NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_T_PlayableGraph_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, 100666095);
			ScriptPlayable<T>.NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_T_PlayableGraph_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, 100666096);
			ScriptPlayable<T>.NativeMethodInfoPtr_CreateHandle_Private_Static_PlayableHandle_PlayableGraph_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, 100666097);
			ScriptPlayable<T>.NativeMethodInfoPtr_CreateScriptInstance_Private_Static_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, 100666098);
			ScriptPlayable<T>.NativeMethodInfoPtr_CloneScriptInstance_Private_Static_Object_IPlayableBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, 100666099);
			ScriptPlayable<T>.NativeMethodInfoPtr_CloneScriptInstanceFromEngineObject_Private_Static_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, 100666100);
			ScriptPlayable<T>.NativeMethodInfoPtr_CloneScriptInstanceFromIClonable_Private_Static_Object_ICloneable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, 100666101);
			ScriptPlayable<T>.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, 100666102);
			ScriptPlayable<T>.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, 100666103);
			ScriptPlayable<T>.NativeMethodInfoPtr_GetBehaviour_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, 100666104);
			ScriptPlayable<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_Playable_ScriptPlayable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, 100666105);
			ScriptPlayable<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScriptPlayable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, 100666106);
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06001EA6 RID: 7846 RVA: 0x00070A9C File Offset: 0x0006EC9C
		public unsafe static ScriptPlayable<T> Null
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 504200, RefRangeEnd = 504208, XrefRangeStart = 504191, XrefRangeEnd = 504200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptPlayable<T>.NativeMethodInfoPtr_get_Null_Public_Static_get_ScriptPlayable_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ScriptPlayable<T>(intPtr);
			}
		}

		// Token: 0x06001EA7 RID: 7847 RVA: 0x00070AC8 File Offset: 0x0006ECC8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 504219, RefRangeEnd = 504230, XrefRangeStart = 504208, XrefRangeEnd = 504219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptPlayable<T> Create(PlayableGraph graph, int inputCount = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptPlayable<T>.NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_T_PlayableGraph_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ScriptPlayable<T>(intPtr);
		}

		// Token: 0x06001EA8 RID: 7848 RVA: 0x00070B10 File Offset: 0x0006ED10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 504241, RefRangeEnd = 504243, XrefRangeStart = 504230, XrefRangeEnd = 504241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptPlayable<T> Create(PlayableGraph graph, T template, int inputCount = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = template;
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
				ptr4 = ref template;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptPlayable<T>.NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_T_PlayableGraph_T_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ScriptPlayable<T>(intPtr);
		}

		// Token: 0x06001EA9 RID: 7849 RVA: 0x00070BB4 File Offset: 0x0006EDB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504243, XrefRangeEnd = 504292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayableHandle CreateHandle(PlayableGraph graph, T template, int inputCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = template;
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
				ptr4 = ref template;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptPlayable<T>.NativeMethodInfoPtr_CreateHandle_Private_Static_PlayableHandle_PlayableGraph_T_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EAA RID: 7850 RVA: 0x00070C5C File Offset: 0x0006EE5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504292, XrefRangeEnd = 504302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateScriptInstance()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptPlayable<T>.NativeMethodInfoPtr_CreateScriptInstance_Private_Static_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001EAB RID: 7851 RVA: 0x00070C90 File Offset: 0x0006EE90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504302, XrefRangeEnd = 504339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CloneScriptInstance(IPlayableBehaviour source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptPlayable<T>.NativeMethodInfoPtr_CloneScriptInstance_Private_Static_Object_IPlayableBehaviour_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001EAC RID: 7852 RVA: 0x00070CD4 File Offset: 0x0006EED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504339, XrefRangeEnd = 504355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CloneScriptInstanceFromEngineObject(Object source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptPlayable<T>.NativeMethodInfoPtr_CloneScriptInstanceFromEngineObject_Private_Static_Object_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001EAD RID: 7853 RVA: 0x00070D18 File Offset: 0x0006EF18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504355, XrefRangeEnd = 504359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CloneScriptInstanceFromIClonable(ICloneable source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptPlayable<T>.NativeMethodInfoPtr_CloneScriptInstanceFromIClonable_Private_Static_Object_ICloneable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001EAE RID: 7854 RVA: 0x00070D5C File Offset: 0x0006EF5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 504366, RefRangeEnd = 504368, XrefRangeStart = 504359, XrefRangeEnd = 504366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScriptPlayable(PlayableHandle handle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptPlayable<T>.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EAF RID: 7855 RVA: 0x00070DA8 File Offset: 0x0006EFA8
		[CallerCount(0)]
		public unsafe PlayableHandle GetHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptPlayable<T>.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EB0 RID: 7856 RVA: 0x00070DEC File Offset: 0x0006EFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504368, XrefRangeEnd = 504370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetBehaviour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptPlayable<T>.NativeMethodInfoPtr_GetBehaviour_Public_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001EB1 RID: 7857 RVA: 0x00070E2C File Offset: 0x0006F02C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504370, XrefRangeEnd = 504371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Playable(ScriptPlayable<T> playable)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(playable));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptPlayable<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_Playable_ScriptPlayable_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EB2 RID: 7858 RVA: 0x00070E74 File Offset: 0x0006F074
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 504380, RefRangeEnd = 504381, XrefRangeStart = 504371, XrefRangeEnd = 504380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(ScriptPlayable<T> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptPlayable<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScriptPlayable_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EB3 RID: 7859 RVA: 0x00010034 File Offset: 0x0000E234
		public ScriptPlayable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001EB4 RID: 7860 RVA: 0x0001003D File Offset: 0x0000E23D
		public ScriptPlayable()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr))
		{
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06001EB5 RID: 7861 RVA: 0x00070ECC File Offset: 0x0006F0CC
		// (set) Token: 0x06001EB6 RID: 7862 RVA: 0x0001004F File Offset: 0x0000E24F
		public unsafe PlayableHandle m_Handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptPlayable<T>.NativeFieldInfoPtr_m_Handle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptPlayable<T>.NativeFieldInfoPtr_m_Handle)) = value;
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06001EB7 RID: 7863 RVA: 0x00070EF4 File Offset: 0x0006F0F4
		// (set) Token: 0x06001EB8 RID: 7864 RVA: 0x0001006A File Offset: 0x0000E26A
		public unsafe static ScriptPlayable<T> m_NullPlayable
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(ScriptPlayable<T>.NativeFieldInfoPtr_m_NullPlayable, intPtr);
				return new ScriptPlayable<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptPlayable<T>.NativeFieldInfoPtr_m_NullPlayable, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x06001EB9 RID: 7865 RVA: 0x00070F30 File Offset: 0x0006F130
		public static explicit operator ScriptPlayable<T>(Playable playable)
		{
			return new ScriptPlayable<T>(playable.GetHandle());
		}

		// Token: 0x0400177C RID: 6012
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x0400177D RID: 6013
		private static readonly IntPtr NativeFieldInfoPtr_m_NullPlayable;

		// Token: 0x0400177E RID: 6014
		private static readonly IntPtr NativeMethodInfoPtr_get_Null_Public_Static_get_ScriptPlayable_1_T_0;

		// Token: 0x0400177F RID: 6015
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_T_PlayableGraph_Int32_0;

		// Token: 0x04001780 RID: 6016
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_T_PlayableGraph_T_Int32_0;

		// Token: 0x04001781 RID: 6017
		private static readonly IntPtr NativeMethodInfoPtr_CreateHandle_Private_Static_PlayableHandle_PlayableGraph_T_Int32_0;

		// Token: 0x04001782 RID: 6018
		private static readonly IntPtr NativeMethodInfoPtr_CreateScriptInstance_Private_Static_Object_0;

		// Token: 0x04001783 RID: 6019
		private static readonly IntPtr NativeMethodInfoPtr_CloneScriptInstance_Private_Static_Object_IPlayableBehaviour_0;

		// Token: 0x04001784 RID: 6020
		private static readonly IntPtr NativeMethodInfoPtr_CloneScriptInstanceFromEngineObject_Private_Static_Object_Object_0;

		// Token: 0x04001785 RID: 6021
		private static readonly IntPtr NativeMethodInfoPtr_CloneScriptInstanceFromIClonable_Private_Static_Object_ICloneable_0;

		// Token: 0x04001786 RID: 6022
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0;

		// Token: 0x04001787 RID: 6023
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x04001788 RID: 6024
		private static readonly IntPtr NativeMethodInfoPtr_GetBehaviour_Public_T_0;

		// Token: 0x04001789 RID: 6025
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Playable_ScriptPlayable_1_T_0;

		// Token: 0x0400178A RID: 6026
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScriptPlayable_1_T_0;
	}
}
