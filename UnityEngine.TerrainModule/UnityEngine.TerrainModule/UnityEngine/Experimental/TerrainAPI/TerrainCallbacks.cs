using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.TerrainAPI
{
	// Token: 0x02000004 RID: 4
	public static class TerrainCallbacks : Object
	{
		// Token: 0x060000F2 RID: 242 RVA: 0x00005430 File Offset: 0x00003630
		// Note: this type is marked as 'beforefieldinit'.
		static TerrainCallbacks()
		{
			Il2CppClassPointerStore<TerrainCallbacks>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TerrainModule.dll", "UnityEngine.Experimental.TerrainAPI", "TerrainCallbacks");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainCallbacks>.NativeClassPtr);
			TerrainCallbacks.NativeFieldInfoPtr_heightmapChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainCallbacks>.NativeClassPtr, "heightmapChanged");
			TerrainCallbacks.NativeFieldInfoPtr_textureChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainCallbacks>.NativeClassPtr, "textureChanged");
			TerrainCallbacks.NativeMethodInfoPtr_InvokeHeightmapChangedCallback_Internal_Static_Void_TerrainData_RectInt_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainCallbacks>.NativeClassPtr, 100663318);
			TerrainCallbacks.NativeMethodInfoPtr_InvokeTextureChangedCallback_Internal_Static_Void_TerrainData_String_RectInt_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainCallbacks>.NativeClassPtr, 100663319);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000054B0 File Offset: 0x000036B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514349, XrefRangeEnd = 514356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeHeightmapChangedCallback(TerrainData terrainData, RectInt heightRegion, bool synched)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(terrainData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref heightRegion;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref synched;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainCallbacks.NativeMethodInfoPtr_InvokeHeightmapChangedCallback_Internal_Static_Void_TerrainData_RectInt_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00005504 File Offset: 0x00003704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514356, XrefRangeEnd = 514363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeTextureChangedCallback(TerrainData terrainData, string textureName, RectInt texelRegion, bool synched)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(terrainData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(textureName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref texelRegion;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref synched;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainCallbacks.NativeMethodInfoPtr_InvokeTextureChangedCallback_Internal_Static_Void_TerrainData_String_RectInt_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002ADD File Offset: 0x00000CDD
		public TerrainCallbacks(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x00005568 File Offset: 0x00003768
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x00002AE6 File Offset: 0x00000CE6
		public unsafe static TerrainCallbacks.HeightmapChangedCallback heightmapChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TerrainCallbacks.NativeFieldInfoPtr_heightmapChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TerrainCallbacks.HeightmapChangedCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TerrainCallbacks.NativeFieldInfoPtr_heightmapChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00005590 File Offset: 0x00003790
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x00002AF8 File Offset: 0x00000CF8
		public unsafe static TerrainCallbacks.TextureChangedCallback textureChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TerrainCallbacks.NativeFieldInfoPtr_textureChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TerrainCallbacks.TextureChangedCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TerrainCallbacks.NativeFieldInfoPtr_textureChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002B0A File Offset: 0x00000D0A
		public static void add_heightmapChanged(TerrainCallbacks.HeightmapChangedCallback value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002B17 File Offset: 0x00000D17
		public static void remove_heightmapChanged(TerrainCallbacks.HeightmapChangedCallback value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002B24 File Offset: 0x00000D24
		public static void add_textureChanged(TerrainCallbacks.TextureChangedCallback value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00002B31 File Offset: 0x00000D31
		public static void remove_textureChanged(TerrainCallbacks.TextureChangedCallback value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeFieldInfoPtr_heightmapChanged;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeFieldInfoPtr_textureChanged;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_InvokeHeightmapChangedCallback_Internal_Static_Void_TerrainData_RectInt_Boolean_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_InvokeTextureChangedCallback_Internal_Static_Void_TerrainData_String_RectInt_Boolean_0;

		// Token: 0x020000A1 RID: 161
		public sealed class HeightmapChangedCallback : MulticastDelegate
		{
			// Token: 0x060002C3 RID: 707 RVA: 0x00006664 File Offset: 0x00004864
			// Note: this type is marked as 'beforefieldinit'.
			static HeightmapChangedCallback()
			{
				Il2CppClassPointerStore<TerrainCallbacks.HeightmapChangedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TerrainCallbacks>.NativeClassPtr, "HeightmapChangedCallback");
				TerrainCallbacks.HeightmapChangedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainCallbacks.HeightmapChangedCallback>.NativeClassPtr, 100663320);
				TerrainCallbacks.HeightmapChangedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Terrain_RectInt_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainCallbacks.HeightmapChangedCallback>.NativeClassPtr, 100663321);
				TerrainCallbacks.HeightmapChangedCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Terrain_RectInt_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainCallbacks.HeightmapChangedCallback>.NativeClassPtr, 100663322);
				TerrainCallbacks.HeightmapChangedCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainCallbacks.HeightmapChangedCallback>.NativeClassPtr, 100663323);
			}

			// Token: 0x060002C4 RID: 708 RVA: 0x000066D8 File Offset: 0x000048D8
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HeightmapChangedCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TerrainCallbacks.HeightmapChangedCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainCallbacks.HeightmapChangedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002C5 RID: 709 RVA: 0x00006734 File Offset: 0x00004934
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 514333, RefRangeEnd = 514334, XrefRangeStart = 514333, XrefRangeEnd = 514333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(Terrain terrain, RectInt heightRegion, bool synched)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(terrain);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref heightRegion;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref synched;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainCallbacks.HeightmapChangedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Terrain_RectInt_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002C6 RID: 710 RVA: 0x00006794 File Offset: 0x00004994
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514334, XrefRangeEnd = 514341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Terrain terrain, RectInt heightRegion, bool synched, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(terrain);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref heightRegion;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref synched;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainCallbacks.HeightmapChangedCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Terrain_RectInt_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x060002C7 RID: 711 RVA: 0x00006828 File Offset: 0x00004A28
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainCallbacks.HeightmapChangedCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060002C8 RID: 712 RVA: 0x0000328B File Offset: 0x0000148B
			public HeightmapChangedCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060002C9 RID: 713 RVA: 0x00003294 File Offset: 0x00001494
			public static implicit operator TerrainCallbacks.HeightmapChangedCallback(Action<Terrain, RectInt, bool> A_0)
			{
				return DelegateSupport.ConvertDelegate<TerrainCallbacks.HeightmapChangedCallback>(A_0);
			}

			// Token: 0x060002CA RID: 714 RVA: 0x0000329C File Offset: 0x0000149C
			public static TerrainCallbacks.HeightmapChangedCallback operator +(TerrainCallbacks.HeightmapChangedCallback A_0, TerrainCallbacks.HeightmapChangedCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<TerrainCallbacks.HeightmapChangedCallback>();
			}

			// Token: 0x060002CB RID: 715 RVA: 0x000032AA File Offset: 0x000014AA
			public static TerrainCallbacks.HeightmapChangedCallback operator -(TerrainCallbacks.HeightmapChangedCallback A_0, TerrainCallbacks.HeightmapChangedCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<TerrainCallbacks.HeightmapChangedCallback>();
				}
				return delegate2;
			}

			// Token: 0x04000105 RID: 261
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04000106 RID: 262
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Terrain_RectInt_Boolean_0;

			// Token: 0x04000107 RID: 263
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Terrain_RectInt_Boolean_AsyncCallback_Object_0;

			// Token: 0x04000108 RID: 264
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020000A2 RID: 162
		public sealed class TextureChangedCallback : MulticastDelegate
		{
			// Token: 0x060002CC RID: 716 RVA: 0x0000686C File Offset: 0x00004A6C
			// Note: this type is marked as 'beforefieldinit'.
			static TextureChangedCallback()
			{
				Il2CppClassPointerStore<TerrainCallbacks.TextureChangedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TerrainCallbacks>.NativeClassPtr, "TextureChangedCallback");
				TerrainCallbacks.TextureChangedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainCallbacks.TextureChangedCallback>.NativeClassPtr, 100663324);
				TerrainCallbacks.TextureChangedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Terrain_String_RectInt_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainCallbacks.TextureChangedCallback>.NativeClassPtr, 100663325);
				TerrainCallbacks.TextureChangedCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Terrain_String_RectInt_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainCallbacks.TextureChangedCallback>.NativeClassPtr, 100663326);
				TerrainCallbacks.TextureChangedCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainCallbacks.TextureChangedCallback>.NativeClassPtr, 100663327);
			}

			// Token: 0x060002CD RID: 717 RVA: 0x000068E0 File Offset: 0x00004AE0
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TextureChangedCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TerrainCallbacks.TextureChangedCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainCallbacks.TextureChangedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002CE RID: 718 RVA: 0x0000693C File Offset: 0x00004B3C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 514341, RefRangeEnd = 514342, XrefRangeStart = 514341, XrefRangeEnd = 514341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(Terrain terrain, string textureName, RectInt texelRegion, bool synched)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(terrain);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(textureName);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref texelRegion;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref synched;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainCallbacks.TextureChangedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Terrain_String_RectInt_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002CF RID: 719 RVA: 0x000069AC File Offset: 0x00004BAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514342, XrefRangeEnd = 514349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Terrain terrain, string textureName, RectInt texelRegion, bool synched, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(terrain);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(textureName);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref texelRegion;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref synched;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainCallbacks.TextureChangedCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Terrain_String_RectInt_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x060002D0 RID: 720 RVA: 0x00006A50 File Offset: 0x00004C50
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainCallbacks.TextureChangedCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060002D1 RID: 721 RVA: 0x000032BB File Offset: 0x000014BB
			public TextureChangedCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060002D2 RID: 722 RVA: 0x000032C4 File Offset: 0x000014C4
			public static implicit operator TerrainCallbacks.TextureChangedCallback(Action<Terrain, string, RectInt, bool> A_0)
			{
				return DelegateSupport.ConvertDelegate<TerrainCallbacks.TextureChangedCallback>(A_0);
			}

			// Token: 0x060002D3 RID: 723 RVA: 0x000032CC File Offset: 0x000014CC
			public static TerrainCallbacks.TextureChangedCallback operator +(TerrainCallbacks.TextureChangedCallback A_0, TerrainCallbacks.TextureChangedCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<TerrainCallbacks.TextureChangedCallback>();
			}

			// Token: 0x060002D4 RID: 724 RVA: 0x000032DA File Offset: 0x000014DA
			public static TerrainCallbacks.TextureChangedCallback operator -(TerrainCallbacks.TextureChangedCallback A_0, TerrainCallbacks.TextureChangedCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<TerrainCallbacks.TextureChangedCallback>();
				}
				return delegate2;
			}

			// Token: 0x04000109 RID: 265
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400010A RID: 266
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Terrain_String_RectInt_Boolean_0;

			// Token: 0x0400010B RID: 267
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Terrain_String_RectInt_Boolean_AsyncCallback_Object_0;

			// Token: 0x0400010C RID: 268
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
