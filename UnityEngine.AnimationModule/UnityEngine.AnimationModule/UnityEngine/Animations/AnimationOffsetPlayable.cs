using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Animations
{
	// Token: 0x02000020 RID: 32
	[StructLayout(2)]
	public struct AnimationOffsetPlayable
	{
		// Token: 0x0600037A RID: 890 RVA: 0x0000C1F4 File Offset: 0x0000A3F4
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationOffsetPlayable()
		{
			Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimationOffsetPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr);
			AnimationOffsetPlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, "m_Handle");
			AnimationOffsetPlayable.NativeFieldInfoPtr_m_NullPlayable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, "m_NullPlayable");
			AnimationOffsetPlayable.NativeMethodInfoPtr_Create_Public_Static_AnimationOffsetPlayable_PlayableGraph_Vector3_Quaternion_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, 100663421);
			AnimationOffsetPlayable.NativeMethodInfoPtr_CreateHandle_Private_Static_PlayableHandle_PlayableGraph_Vector3_Quaternion_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, 100663422);
			AnimationOffsetPlayable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, 100663423);
			AnimationOffsetPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, 100663424);
			AnimationOffsetPlayable.NativeMethodInfoPtr_op_Implicit_Public_Static_Playable_AnimationOffsetPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, 100663425);
			AnimationOffsetPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationOffsetPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, 100663426);
			AnimationOffsetPlayable.NativeMethodInfoPtr_CreateHandleInternal_Private_Static_Boolean_PlayableGraph_Vector3_Quaternion_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, 100663427);
			AnimationOffsetPlayable.NativeMethodInfoPtr_CreateHandleInternal_Injected_Private_Static_Boolean_byref_PlayableGraph_byref_Vector3_byref_Quaternion_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, 100663429);
			AnimationOffsetPlayable.GetPositionInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimationOffsetPlayable.GetPositionInternal_InjectedDelegate>("UnityEngine.Animations.AnimationOffsetPlayable::GetPositionInternal_Injected");
			AnimationOffsetPlayable.SetPositionInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimationOffsetPlayable.SetPositionInternal_InjectedDelegate>("UnityEngine.Animations.AnimationOffsetPlayable::SetPositionInternal_Injected");
			AnimationOffsetPlayable.GetRotationInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimationOffsetPlayable.GetRotationInternal_InjectedDelegate>("UnityEngine.Animations.AnimationOffsetPlayable::GetRotationInternal_Injected");
			AnimationOffsetPlayable.SetRotationInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimationOffsetPlayable.SetRotationInternal_InjectedDelegate>("UnityEngine.Animations.AnimationOffsetPlayable::SetRotationInternal_Injected");
		}

		// Token: 0x0600037B RID: 891 RVA: 0x0000C328 File Offset: 0x0000A528
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 484399, RefRangeEnd = 484402, XrefRangeStart = 484379, XrefRangeEnd = 484399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AnimationOffsetPlayable Create(PlayableGraph graph, Vector3 position, Quaternion rotation, int inputCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationOffsetPlayable.NativeMethodInfoPtr_Create_Public_Static_AnimationOffsetPlayable_PlayableGraph_Vector3_Quaternion_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0000C390 File Offset: 0x0000A590
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 484432, RefRangeEnd = 484433, XrefRangeStart = 484402, XrefRangeEnd = 484432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayableHandle CreateHandle(PlayableGraph graph, Vector3 position, Quaternion rotation, int inputCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationOffsetPlayable.NativeMethodInfoPtr_CreateHandle_Private_Static_PlayableHandle_PlayableGraph_Vector3_Quaternion_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0000C3F8 File Offset: 0x0000A5F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484433, XrefRangeEnd = 484437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationOffsetPlayable(PlayableHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationOffsetPlayable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0000C42C File Offset: 0x0000A62C
		[CallerCount(0)]
		public unsafe PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationOffsetPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600037F RID: 895 RVA: 0x0000C45C File Offset: 0x0000A65C
		[CallerCount(0)]
		public unsafe static implicit operator Playable(AnimationOffsetPlayable playable)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationOffsetPlayable.NativeMethodInfoPtr_op_Implicit_Public_Static_Playable_AnimationOffsetPlayable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000380 RID: 896 RVA: 0x0000C49C File Offset: 0x0000A69C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484437, XrefRangeEnd = 484443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(AnimationOffsetPlayable other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationOffsetPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationOffsetPlayable_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000381 RID: 897 RVA: 0x0000C4DC File Offset: 0x0000A6DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484443, XrefRangeEnd = 484448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CreateHandleInternal(PlayableGraph graph, Vector3 position, Quaternion rotation, ref PlayableHandle handle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationOffsetPlayable.NativeMethodInfoPtr_CreateHandleInternal_Private_Static_Boolean_PlayableGraph_Vector3_Quaternion_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000382 RID: 898 RVA: 0x0000C544 File Offset: 0x0000A744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484448, XrefRangeEnd = 484452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref Vector3 position, ref Quaternion rotation, ref PlayableHandle handle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationOffsetPlayable.NativeMethodInfoPtr_CreateHandleInternal_Injected_Private_Static_Boolean_byref_PlayableGraph_byref_Vector3_byref_Quaternion_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00004125 File Offset: 0x00002325
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, ref this));
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000384 RID: 900 RVA: 0x0000C5AC File Offset: 0x0000A7AC
		// (set) Token: 0x06000385 RID: 901 RVA: 0x00004137 File Offset: 0x00002337
		public unsafe static AnimationOffsetPlayable m_NullPlayable
		{
			get
			{
				AnimationOffsetPlayable animationOffsetPlayable;
				IL2CPP.il2cpp_field_static_get_value(AnimationOffsetPlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&animationOffsetPlayable));
				return animationOffsetPlayable;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AnimationOffsetPlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&value));
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000386 RID: 902 RVA: 0x0000C5C8 File Offset: 0x0000A7C8
		public static AnimationOffsetPlayable Null
		{
			get
			{
				return AnimationOffsetPlayable.m_NullPlayable;
			}
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0000C5E0 File Offset: 0x0000A7E0
		public static explicit operator AnimationOffsetPlayable(Playable playable)
		{
			return new AnimationOffsetPlayable(playable.GetHandle());
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0000C600 File Offset: 0x0000A800
		public Vector3 GetPosition()
		{
			return AnimationOffsetPlayable.GetPositionInternal(ref this.m_Handle);
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00004145 File Offset: 0x00002345
		public void SetPosition(Vector3 value)
		{
			AnimationOffsetPlayable.SetPositionInternal(ref this.m_Handle, value);
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0000C620 File Offset: 0x0000A820
		public Quaternion GetRotation()
		{
			return AnimationOffsetPlayable.GetRotationInternal(ref this.m_Handle);
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00004155 File Offset: 0x00002355
		public void SetRotation(Quaternion value)
		{
			AnimationOffsetPlayable.SetRotationInternal(ref this.m_Handle, value);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0000C640 File Offset: 0x0000A840
		public static Vector3 GetPositionInternal(ref PlayableHandle handle)
		{
			Vector3 vector;
			AnimationOffsetPlayable.GetPositionInternal_Injected(ref handle, out vector);
			return vector;
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00004165 File Offset: 0x00002365
		public static void SetPositionInternal(ref PlayableHandle handle, Vector3 value)
		{
			AnimationOffsetPlayable.SetPositionInternal_Injected(ref handle, ref value);
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0000C658 File Offset: 0x0000A858
		public static Quaternion GetRotationInternal(ref PlayableHandle handle)
		{
			Quaternion quaternion;
			AnimationOffsetPlayable.GetRotationInternal_Injected(ref handle, out quaternion);
			return quaternion;
		}

		// Token: 0x0600038F RID: 911 RVA: 0x0000416F File Offset: 0x0000236F
		public static void SetRotationInternal(ref PlayableHandle handle, Quaternion value)
		{
			AnimationOffsetPlayable.SetRotationInternal_Injected(ref handle, ref value);
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00004179 File Offset: 0x00002379
		public static void GetPositionInternal_Injected(ref PlayableHandle handle, out Vector3 ret)
		{
			AnimationOffsetPlayable.GetPositionInternal_InjectedDelegateField(ref handle, out ret);
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00004187 File Offset: 0x00002387
		public static void SetPositionInternal_Injected(ref PlayableHandle handle, ref Vector3 value)
		{
			AnimationOffsetPlayable.SetPositionInternal_InjectedDelegateField(ref handle, ref value);
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00004195 File Offset: 0x00002395
		public static void GetRotationInternal_Injected(ref PlayableHandle handle, out Quaternion ret)
		{
			AnimationOffsetPlayable.GetRotationInternal_InjectedDelegateField(ref handle, out ret);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x000041A3 File Offset: 0x000023A3
		public static void SetRotationInternal_Injected(ref PlayableHandle handle, ref Quaternion value)
		{
			AnimationOffsetPlayable.SetRotationInternal_InjectedDelegateField(ref handle, ref value);
		}

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeFieldInfoPtr_m_NullPlayable;

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_AnimationOffsetPlayable_PlayableGraph_Vector3_Quaternion_Int32_0;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeMethodInfoPtr_CreateHandle_Private_Static_PlayableHandle_PlayableGraph_Vector3_Quaternion_Int32_0;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Playable_AnimationOffsetPlayable_0;

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationOffsetPlayable_0;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeMethodInfoPtr_CreateHandleInternal_Private_Static_Boolean_PlayableGraph_Vector3_Quaternion_byref_PlayableHandle_0;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeMethodInfoPtr_CreateHandleInternal_Injected_Private_Static_Boolean_byref_PlayableGraph_byref_Vector3_byref_Quaternion_byref_PlayableHandle_0;

		// Token: 0x04000218 RID: 536
		[FieldOffset(0)]
		public PlayableHandle m_Handle;

		// Token: 0x04000219 RID: 537
		private static readonly AnimationOffsetPlayable.GetPositionInternal_InjectedDelegate GetPositionInternal_InjectedDelegateField;

		// Token: 0x0400021A RID: 538
		private static readonly AnimationOffsetPlayable.SetPositionInternal_InjectedDelegate SetPositionInternal_InjectedDelegateField;

		// Token: 0x0400021B RID: 539
		private static readonly AnimationOffsetPlayable.GetRotationInternal_InjectedDelegate GetRotationInternal_InjectedDelegateField;

		// Token: 0x0400021C RID: 540
		private static readonly AnimationOffsetPlayable.SetRotationInternal_InjectedDelegate SetRotationInternal_InjectedDelegateField;

		// Token: 0x02000185 RID: 389
		// (Invoke) Token: 0x06000801 RID: 2049
		private delegate void GetPositionInternal_InjectedDelegate(IntPtr handle, [Out] IntPtr ret);

		// Token: 0x02000186 RID: 390
		// (Invoke) Token: 0x06000803 RID: 2051
		private delegate void SetPositionInternal_InjectedDelegate(IntPtr handle, IntPtr value);

		// Token: 0x02000187 RID: 391
		// (Invoke) Token: 0x06000805 RID: 2053
		private delegate void GetRotationInternal_InjectedDelegate(IntPtr handle, [Out] IntPtr ret);

		// Token: 0x02000188 RID: 392
		// (Invoke) Token: 0x06000807 RID: 2055
		private delegate void SetRotationInternal_InjectedDelegate(IntPtr handle, IntPtr value);
	}
}
