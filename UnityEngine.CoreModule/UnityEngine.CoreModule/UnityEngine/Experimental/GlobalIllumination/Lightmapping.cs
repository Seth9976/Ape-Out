using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x020001A1 RID: 417
	public static class Lightmapping : Object
	{
		// Token: 0x06001F00 RID: 7936 RVA: 0x000724BC File Offset: 0x000706BC
		// Note: this type is marked as 'beforefieldinit'.
		static Lightmapping()
		{
			Il2CppClassPointerStore<Lightmapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "Lightmapping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lightmapping>.NativeClassPtr);
			Lightmapping.NativeFieldInfoPtr_s_DefaultDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lightmapping>.NativeClassPtr, "s_DefaultDelegate");
			Lightmapping.NativeFieldInfoPtr_s_RequestLightsDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lightmapping>.NativeClassPtr, "s_RequestLightsDelegate");
			Lightmapping.NativeMethodInfoPtr_SetDelegate_Public_Static_Void_RequestLightsDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lightmapping>.NativeClassPtr, 100666140);
			Lightmapping.NativeMethodInfoPtr_GetDelegate_Public_Static_RequestLightsDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lightmapping>.NativeClassPtr, 100666141);
			Lightmapping.NativeMethodInfoPtr_ResetDelegate_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lightmapping>.NativeClassPtr, 100666142);
			Lightmapping.NativeMethodInfoPtr_RequestLights_Internal_Static_Void_Il2CppReferenceArray_1_Light_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lightmapping>.NativeClassPtr, 100666143);
		}

		// Token: 0x06001F01 RID: 7937 RVA: 0x00072564 File Offset: 0x00070764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504676, XrefRangeEnd = 504682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetDelegate(Lightmapping.RequestLightsDelegate del)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(del);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lightmapping.NativeMethodInfoPtr_SetDelegate_Public_Static_Void_RequestLightsDelegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F02 RID: 7938 RVA: 0x0007259C File Offset: 0x0007079C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504682, XrefRangeEnd = 504686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Lightmapping.RequestLightsDelegate GetDelegate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lightmapping.NativeMethodInfoPtr_GetDelegate_Public_Static_RequestLightsDelegate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Lightmapping.RequestLightsDelegate>(intPtr3) : null;
		}

		// Token: 0x06001F03 RID: 7939 RVA: 0x000725D0 File Offset: 0x000707D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504686, XrefRangeEnd = 504690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ResetDelegate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lightmapping.NativeMethodInfoPtr_ResetDelegate_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F04 RID: 7940 RVA: 0x000725F8 File Offset: 0x000707F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504690, XrefRangeEnd = 504696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RequestLights(Il2CppReferenceArray<Light> lights, IntPtr outLightsPtr, int outLightsCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lights);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref outLightsPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref outLightsCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lightmapping.NativeMethodInfoPtr_RequestLights_Internal_Static_Void_Il2CppReferenceArray_1_Light_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F05 RID: 7941 RVA: 0x00010182 File Offset: 0x0000E382
		public Lightmapping(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06001F06 RID: 7942 RVA: 0x0007264C File Offset: 0x0007084C
		// (set) Token: 0x06001F07 RID: 7943 RVA: 0x0001018B File Offset: 0x0000E38B
		public unsafe static Lightmapping.RequestLightsDelegate s_DefaultDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Lightmapping.NativeFieldInfoPtr_s_DefaultDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lightmapping.RequestLightsDelegate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Lightmapping.NativeFieldInfoPtr_s_DefaultDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06001F08 RID: 7944 RVA: 0x00072674 File Offset: 0x00070874
		// (set) Token: 0x06001F09 RID: 7945 RVA: 0x0001019D File Offset: 0x0000E39D
		public unsafe static Lightmapping.RequestLightsDelegate s_RequestLightsDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Lightmapping.NativeFieldInfoPtr_s_RequestLightsDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lightmapping.RequestLightsDelegate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Lightmapping.NativeFieldInfoPtr_s_RequestLightsDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400187B RID: 6267
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultDelegate;

		// Token: 0x0400187C RID: 6268
		private static readonly IntPtr NativeFieldInfoPtr_s_RequestLightsDelegate;

		// Token: 0x0400187D RID: 6269
		private static readonly IntPtr NativeMethodInfoPtr_SetDelegate_Public_Static_Void_RequestLightsDelegate_0;

		// Token: 0x0400187E RID: 6270
		private static readonly IntPtr NativeMethodInfoPtr_GetDelegate_Public_Static_RequestLightsDelegate_0;

		// Token: 0x0400187F RID: 6271
		private static readonly IntPtr NativeMethodInfoPtr_ResetDelegate_Public_Static_Void_0;

		// Token: 0x04001880 RID: 6272
		private static readonly IntPtr NativeMethodInfoPtr_RequestLights_Internal_Static_Void_Il2CppReferenceArray_1_Light_IntPtr_Int32_0;

		// Token: 0x02000A45 RID: 2629
		public sealed class RequestLightsDelegate : MulticastDelegate
		{
			// Token: 0x06003300 RID: 13056 RVA: 0x00080520 File Offset: 0x0007E720
			// Note: this type is marked as 'beforefieldinit'.
			static RequestLightsDelegate()
			{
				Il2CppClassPointerStore<Lightmapping.RequestLightsDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Lightmapping>.NativeClassPtr, "RequestLightsDelegate");
				Lightmapping.RequestLightsDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lightmapping.RequestLightsDelegate>.NativeClassPtr, 100666145);
				Lightmapping.RequestLightsDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Il2CppReferenceArray_1_Light_NativeArray_1_LightDataGI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lightmapping.RequestLightsDelegate>.NativeClassPtr, 100666146);
				Lightmapping.RequestLightsDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Il2CppReferenceArray_1_Light_NativeArray_1_LightDataGI_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lightmapping.RequestLightsDelegate>.NativeClassPtr, 100666147);
				Lightmapping.RequestLightsDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lightmapping.RequestLightsDelegate>.NativeClassPtr, 100666148);
			}

			// Token: 0x06003301 RID: 13057 RVA: 0x00080594 File Offset: 0x0007E794
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RequestLightsDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lightmapping.RequestLightsDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lightmapping.RequestLightsDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003302 RID: 13058 RVA: 0x000805F0 File Offset: 0x0007E7F0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 504652, RefRangeEnd = 504653, XrefRangeStart = 504652, XrefRangeEnd = 504652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(Il2CppReferenceArray<Light> requests, Unity.Collections.NativeArray<LightDataGI> lightsOutput)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(requests);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lightsOutput));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lightmapping.RequestLightsDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Il2CppReferenceArray_1_Light_NativeArray_1_LightDataGI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003303 RID: 13059 RVA: 0x0008064C File Offset: 0x0007E84C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504653, XrefRangeEnd = 504657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Il2CppReferenceArray<Light> requests, Unity.Collections.NativeArray<LightDataGI> lightsOutput, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(requests);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lightsOutput));
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lightmapping.RequestLightsDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Il2CppReferenceArray_1_Light_NativeArray_1_LightDataGI_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06003304 RID: 13060 RVA: 0x000806D8 File Offset: 0x0007E8D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lightmapping.RequestLightsDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003305 RID: 13061 RVA: 0x00015704 File Offset: 0x00013904
			public RequestLightsDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003306 RID: 13062 RVA: 0x0001570D File Offset: 0x0001390D
			public static implicit operator Lightmapping.RequestLightsDelegate(Action<Il2CppReferenceArray<Light>, Unity.Collections.NativeArray<LightDataGI>> A_0)
			{
				return DelegateSupport.ConvertDelegate<Lightmapping.RequestLightsDelegate>(A_0);
			}

			// Token: 0x06003307 RID: 13063 RVA: 0x00015715 File Offset: 0x00013915
			public static Lightmapping.RequestLightsDelegate operator +(Lightmapping.RequestLightsDelegate A_0, Lightmapping.RequestLightsDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Lightmapping.RequestLightsDelegate>();
			}

			// Token: 0x06003308 RID: 13064 RVA: 0x00015723 File Offset: 0x00013923
			public static Lightmapping.RequestLightsDelegate operator -(Lightmapping.RequestLightsDelegate A_0, Lightmapping.RequestLightsDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<Lightmapping.RequestLightsDelegate>();
				}
				return delegate2;
			}

			// Token: 0x04002000 RID: 8192
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002001 RID: 8193
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Il2CppReferenceArray_1_Light_NativeArray_1_LightDataGI_0;

			// Token: 0x04002002 RID: 8194
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Il2CppReferenceArray_1_Light_NativeArray_1_LightDataGI_AsyncCallback_Object_0;

			// Token: 0x04002003 RID: 8195
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000A46 RID: 2630
		[ObfuscatedName("UnityEngine.Experimental.GlobalIllumination.Lightmapping+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003309 RID: 13065 RVA: 0x0008071C File Offset: 0x0007E91C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Lightmapping.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Lightmapping>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lightmapping.__c>.NativeClassPtr);
				Lightmapping.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lightmapping.__c>.NativeClassPtr, "<>9");
				Lightmapping.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lightmapping.__c>.NativeClassPtr, 100666150);
				Lightmapping.__c.NativeMethodInfoPtr___cctor_b__7_0_Internal_Void_Il2CppReferenceArray_1_Light_NativeArray_1_LightDataGI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lightmapping.__c>.NativeClassPtr, 100666151);
			}

			// Token: 0x0600330A RID: 13066 RVA: 0x00080784 File Offset: 0x0007E984
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lightmapping.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lightmapping.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600330B RID: 13067 RVA: 0x000807C0 File Offset: 0x0007E9C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504657, XrefRangeEnd = 504676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__7_0(Il2CppReferenceArray<Light> requests, Unity.Collections.NativeArray<LightDataGI> lightsOutput)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(requests);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lightsOutput));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lightmapping.__c.NativeMethodInfoPtr___cctor_b__7_0_Internal_Void_Il2CppReferenceArray_1_Light_NativeArray_1_LightDataGI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600330C RID: 13068 RVA: 0x00015734 File Offset: 0x00013934
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700073C RID: 1852
			// (get) Token: 0x0600330D RID: 13069 RVA: 0x0008081C File Offset: 0x0007EA1C
			// (set) Token: 0x0600330E RID: 13070 RVA: 0x0001573D File Offset: 0x0001393D
			public unsafe static Lightmapping.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Lightmapping.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lightmapping.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Lightmapping.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002004 RID: 8196
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002005 RID: 8197
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002006 RID: 8198
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__7_0_Internal_Void_Il2CppReferenceArray_1_Light_NativeArray_1_LightDataGI_0;
		}

		// Token: 0x02000A47 RID: 2631
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
