using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Playables
{
	// Token: 0x02000186 RID: 390
	public sealed class PlayableBinding : ValueType
	{
		// Token: 0x06001D67 RID: 7527 RVA: 0x0006C0AC File Offset: 0x0006A2AC
		// Note: this type is marked as 'beforefieldinit'.
		static PlayableBinding()
		{
			Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "PlayableBinding");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr);
			PlayableBinding.NativeFieldInfoPtr_m_StreamName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, "m_StreamName");
			PlayableBinding.NativeFieldInfoPtr_m_SourceObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, "m_SourceObject");
			PlayableBinding.NativeFieldInfoPtr_m_SourceBindingType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, "m_SourceBindingType");
			PlayableBinding.NativeFieldInfoPtr_m_CreateOutputMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, "m_CreateOutputMethod");
			PlayableBinding.NativeFieldInfoPtr_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, "None");
			PlayableBinding.NativeFieldInfoPtr_DefaultDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, "DefaultDuration");
			PlayableBinding.NativeMethodInfoPtr_get_sourceObject_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, 100665938);
			PlayableBinding.NativeMethodInfoPtr_CreateOutput_Internal_PlayableOutput_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, 100665939);
			PlayableBinding.NativeMethodInfoPtr_CreateInternal_Internal_Static_PlayableBinding_String_Object_Type_CreateOutputMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, 100665940);
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06001D68 RID: 7528 RVA: 0x0006C190 File Offset: 0x0006A390
		// (set) Token: 0x06001D7B RID: 7547 RVA: 0x0000FBA1 File Offset: 0x0000DDA1
		public unsafe Object sourceObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableBinding.NativeMethodInfoPtr_get_sourceObject_Public_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			set
			{
				this.m_SourceObject = value;
			}
		}

		// Token: 0x06001D69 RID: 7529 RVA: 0x0006C1D4 File Offset: 0x0006A3D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503431, XrefRangeEnd = 503441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayableOutput CreateOutput(PlayableGraph graph)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableBinding.NativeMethodInfoPtr_CreateOutput_Internal_PlayableOutput_PlayableGraph_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D6A RID: 7530 RVA: 0x0006C224 File Offset: 0x0006A424
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 503441, RefRangeEnd = 503444, XrefRangeStart = 503441, XrefRangeEnd = 503441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayableBinding CreateInternal(string name, Object sourceObject, Type sourceType, PlayableBinding.CreateOutputMethod createFunction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceType);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(createFunction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableBinding.NativeMethodInfoPtr_CreateInternal_Internal_Static_PlayableBinding_String_Object_Type_CreateOutputMethod_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new PlayableBinding(intPtr);
		}

		// Token: 0x06001D6B RID: 7531 RVA: 0x0000FAE0 File Offset: 0x0000DCE0
		public PlayableBinding(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001D6C RID: 7532 RVA: 0x0000FAE9 File Offset: 0x0000DCE9
		public PlayableBinding()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr))
		{
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06001D6D RID: 7533 RVA: 0x0006C298 File Offset: 0x0006A498
		// (set) Token: 0x06001D6E RID: 7534 RVA: 0x0000FAFB File Offset: 0x0000DCFB
		public unsafe string m_StreamName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayableBinding.NativeFieldInfoPtr_m_StreamName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayableBinding.NativeFieldInfoPtr_m_StreamName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06001D6F RID: 7535 RVA: 0x0006C2C0 File Offset: 0x0006A4C0
		// (set) Token: 0x06001D70 RID: 7536 RVA: 0x0000FB1A File Offset: 0x0000DD1A
		public unsafe Object m_SourceObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayableBinding.NativeFieldInfoPtr_m_SourceObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayableBinding.NativeFieldInfoPtr_m_SourceObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06001D71 RID: 7537 RVA: 0x0006C2F0 File Offset: 0x0006A4F0
		// (set) Token: 0x06001D72 RID: 7538 RVA: 0x0000FB39 File Offset: 0x0000DD39
		public unsafe Type m_SourceBindingType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayableBinding.NativeFieldInfoPtr_m_SourceBindingType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayableBinding.NativeFieldInfoPtr_m_SourceBindingType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06001D73 RID: 7539 RVA: 0x0006C320 File Offset: 0x0006A520
		// (set) Token: 0x06001D74 RID: 7540 RVA: 0x0000FB58 File Offset: 0x0000DD58
		public unsafe PlayableBinding.CreateOutputMethod m_CreateOutputMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayableBinding.NativeFieldInfoPtr_m_CreateOutputMethod);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayableBinding.CreateOutputMethod>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayableBinding.NativeFieldInfoPtr_m_CreateOutputMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06001D75 RID: 7541 RVA: 0x0006C350 File Offset: 0x0006A550
		// (set) Token: 0x06001D76 RID: 7542 RVA: 0x0000FB77 File Offset: 0x0000DD77
		public unsafe static Il2CppReferenceArray<PlayableBinding> None
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlayableBinding.NativeFieldInfoPtr_None, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlayableBinding>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayableBinding.NativeFieldInfoPtr_None, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06001D77 RID: 7543 RVA: 0x0006C378 File Offset: 0x0006A578
		// (set) Token: 0x06001D78 RID: 7544 RVA: 0x0000FB89 File Offset: 0x0000DD89
		public unsafe static double DefaultDuration
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(PlayableBinding.NativeFieldInfoPtr_DefaultDuration, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayableBinding.NativeFieldInfoPtr_DefaultDuration, (void*)(&value));
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06001D79 RID: 7545 RVA: 0x0006C394 File Offset: 0x0006A594
		// (set) Token: 0x06001D7A RID: 7546 RVA: 0x0000FB97 File Offset: 0x0000DD97
		public string streamName
		{
			get
			{
				return this.m_StreamName;
			}
			set
			{
				this.m_StreamName = value;
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06001D7C RID: 7548 RVA: 0x0006C3AC File Offset: 0x0006A5AC
		public Type outputTargetType
		{
			get
			{
				return this.m_SourceBindingType;
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06001D7D RID: 7549 RVA: 0x0006C3C4 File Offset: 0x0006A5C4
		// (set) Token: 0x06001D7E RID: 7550 RVA: 0x0000FBAB File Offset: 0x0000DDAB
		public Type sourceBindingType
		{
			get
			{
				return this.m_SourceBindingType;
			}
			set
			{
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06001D7F RID: 7551 RVA: 0x0006C3DC File Offset: 0x0006A5DC
		// (set) Token: 0x06001D80 RID: 7552 RVA: 0x0000FBAE File Offset: 0x0000DDAE
		public DataStreamType streamType
		{
			get
			{
				return DataStreamType.None;
			}
			set
			{
			}
		}

		// Token: 0x040016A1 RID: 5793
		private static readonly IntPtr NativeFieldInfoPtr_m_StreamName;

		// Token: 0x040016A2 RID: 5794
		private static readonly IntPtr NativeFieldInfoPtr_m_SourceObject;

		// Token: 0x040016A3 RID: 5795
		private static readonly IntPtr NativeFieldInfoPtr_m_SourceBindingType;

		// Token: 0x040016A4 RID: 5796
		private static readonly IntPtr NativeFieldInfoPtr_m_CreateOutputMethod;

		// Token: 0x040016A5 RID: 5797
		private static readonly IntPtr NativeFieldInfoPtr_None;

		// Token: 0x040016A6 RID: 5798
		private static readonly IntPtr NativeFieldInfoPtr_DefaultDuration;

		// Token: 0x040016A7 RID: 5799
		private static readonly IntPtr NativeMethodInfoPtr_get_sourceObject_Public_get_Object_0;

		// Token: 0x040016A8 RID: 5800
		private static readonly IntPtr NativeMethodInfoPtr_CreateOutput_Internal_PlayableOutput_PlayableGraph_0;

		// Token: 0x040016A9 RID: 5801
		private static readonly IntPtr NativeMethodInfoPtr_CreateInternal_Internal_Static_PlayableBinding_String_Object_Type_CreateOutputMethod_0;

		// Token: 0x020009F6 RID: 2550
		public sealed class CreateOutputMethod : MulticastDelegate
		{
			// Token: 0x0600327E RID: 12926 RVA: 0x0007F774 File Offset: 0x0007D974
			// Note: this type is marked as 'beforefieldinit'.
			static CreateOutputMethod()
			{
				Il2CppClassPointerStore<PlayableBinding.CreateOutputMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, "CreateOutputMethod");
				PlayableBinding.CreateOutputMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableBinding.CreateOutputMethod>.NativeClassPtr, 100665942);
				PlayableBinding.CreateOutputMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_PlayableOutput_PlayableGraph_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableBinding.CreateOutputMethod>.NativeClassPtr, 100665943);
				PlayableBinding.CreateOutputMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_PlayableGraph_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableBinding.CreateOutputMethod>.NativeClassPtr, 100665944);
				PlayableBinding.CreateOutputMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_PlayableOutput_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableBinding.CreateOutputMethod>.NativeClassPtr, 100665945);
			}

			// Token: 0x0600327F RID: 12927 RVA: 0x0007F7E8 File Offset: 0x0007D9E8
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CreateOutputMethod(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayableBinding.CreateOutputMethod>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableBinding.CreateOutputMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003280 RID: 12928 RVA: 0x0007F844 File Offset: 0x0007DA44
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 503425, RefRangeEnd = 503427, XrefRangeStart = 503425, XrefRangeEnd = 503425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlayableOutput Invoke(PlayableGraph graph, string name)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref graph;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableBinding.CreateOutputMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_PlayableOutput_PlayableGraph_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003281 RID: 12929 RVA: 0x0007F8A0 File Offset: 0x0007DAA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503427, XrefRangeEnd = 503431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(PlayableGraph graph, string name, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref graph;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableBinding.CreateOutputMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_PlayableGraph_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06003282 RID: 12930 RVA: 0x0007F924 File Offset: 0x0007DB24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlayableOutput EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableBinding.CreateOutputMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_PlayableOutput_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003283 RID: 12931 RVA: 0x000156D4 File Offset: 0x000138D4
			public CreateOutputMethod(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003284 RID: 12932 RVA: 0x000156DD File Offset: 0x000138DD
			public static implicit operator PlayableBinding.CreateOutputMethod(Func<PlayableGraph, string, PlayableOutput> A_0)
			{
				return DelegateSupport.ConvertDelegate<PlayableBinding.CreateOutputMethod>(A_0);
			}

			// Token: 0x06003285 RID: 12933 RVA: 0x000156E5 File Offset: 0x000138E5
			public static PlayableBinding.CreateOutputMethod operator +(PlayableBinding.CreateOutputMethod A_0, PlayableBinding.CreateOutputMethod A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PlayableBinding.CreateOutputMethod>();
			}

			// Token: 0x06003286 RID: 12934 RVA: 0x000156F3 File Offset: 0x000138F3
			public static PlayableBinding.CreateOutputMethod operator -(PlayableBinding.CreateOutputMethod A_0, PlayableBinding.CreateOutputMethod A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<PlayableBinding.CreateOutputMethod>();
				}
				return delegate2;
			}

			// Token: 0x04001FD9 RID: 8153
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001FDA RID: 8154
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_PlayableOutput_PlayableGraph_String_0;

			// Token: 0x04001FDB RID: 8155
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_PlayableGraph_String_AsyncCallback_Object_0;

			// Token: 0x04001FDC RID: 8156
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_PlayableOutput_IAsyncResult_0;
		}
	}
}
