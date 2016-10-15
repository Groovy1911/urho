// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// RibbonTrail.cs
// 
// Copyright 2015 Xamarin Inc. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using Urho.Urho2D;
using Urho.Gui;
using Urho.Resources;
using Urho.IO;
using Urho.Navigation;
using Urho.Network;

namespace Urho
{
	/// <summary>
	/// Drawable component that creates a tail.
	/// </summary>
	public unsafe partial class RibbonTrail : Drawable
	{
		public RibbonTrail (IntPtr handle) : base (handle)
		{
		}

		protected RibbonTrail (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int RibbonTrail_GetType (IntPtr handle);

		private StringHash UrhoGetType ()
		{
			Runtime.ValidateRefCounted (this);
			return new StringHash (RibbonTrail_GetType (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr RibbonTrail_GetTypeName (IntPtr handle);

		private string GetTypeName ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (RibbonTrail_GetTypeName (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int RibbonTrail_GetTypeStatic ();

		private static StringHash GetTypeStatic ()
		{
			Runtime.Validate (typeof(RibbonTrail));
			return new StringHash (RibbonTrail_GetTypeStatic ());
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr RibbonTrail_GetTypeNameStatic ();

		private static string GetTypeNameStatic ()
		{
			Runtime.Validate (typeof(RibbonTrail));
			return Marshal.PtrToStringAnsi (RibbonTrail_GetTypeNameStatic ());
		}

		public RibbonTrail () : this (Application.CurrentContext)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr RibbonTrail_RibbonTrail (IntPtr context);

		public RibbonTrail (Context context) : base (UrhoObjectFlag.Empty)
		{
			Runtime.Validate (typeof(RibbonTrail));
			handle = RibbonTrail_RibbonTrail ((object)context == null ? IntPtr.Zero : context.Handle);
			Runtime.RegisterObject (this);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void RibbonTrail_RegisterObject (IntPtr context);

		/// <summary>
		/// Register object factory.
		/// </summary>
		public new static void RegisterObject (Context context)
		{
			Runtime.Validate (typeof(RibbonTrail));
			RibbonTrail_RegisterObject ((object)context == null ? IntPtr.Zero : context.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void RibbonTrail_OnSetEnabled (IntPtr handle);

		/// <summary>
		/// Handle enabled/disabled state change.
		/// </summary>
		public override void OnSetEnabled ()
		{
			Runtime.ValidateRefCounted (this);
			RibbonTrail_OnSetEnabled (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern UpdateGeometryType RibbonTrail_GetUpdateGeometryType (IntPtr handle);

		/// <summary>
		/// Return whether a geometry update is necessary, and if it can happen in a worker thread.
		/// </summary>
		private UpdateGeometryType GetUpdateGeometryType ()
		{
			Runtime.ValidateRefCounted (this);
			return RibbonTrail_GetUpdateGeometryType (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void RibbonTrail_SetMaterial (IntPtr handle, IntPtr material);

		/// <summary>
		/// Set material.
		/// </summary>
		private void SetMaterial (Material material)
		{
			Runtime.ValidateRefCounted (this);
			RibbonTrail_SetMaterial (handle, (object)material == null ? IntPtr.Zero : material.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void RibbonTrail_SetVertexDistance (IntPtr handle, float length);

		/// <summary>
		/// Set distance between points.
		/// </summary>
		private void SetVertexDistance (float length)
		{
			Runtime.ValidateRefCounted (this);
			RibbonTrail_SetVertexDistance (handle, length);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void RibbonTrail_SetWidth (IntPtr handle, float width);

		/// <summary>
		/// Set width of the tail. Only works for face camera trail type.
		/// </summary>
		private void SetWidth (float width)
		{
			Runtime.ValidateRefCounted (this);
			RibbonTrail_SetWidth (handle, width);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void RibbonTrail_SetStartColor (IntPtr handle, ref Urho.Color color);

		/// <summary>
		/// Set vertex blended color for start of trail.
		/// </summary>
		private void SetStartColor (Urho.Color color)
		{
			Runtime.ValidateRefCounted (this);
			RibbonTrail_SetStartColor (handle, ref color);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void RibbonTrail_SetEndColor (IntPtr handle, ref Urho.Color color);

		/// <summary>
		/// Set vertex blended scale for end of trail.
		/// </summary>
		private void SetEndColor (Urho.Color color)
		{
			Runtime.ValidateRefCounted (this);
			RibbonTrail_SetEndColor (handle, ref color);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void RibbonTrail_SetStartScale (IntPtr handle, float startScale);

		/// <summary>
		/// Set vertex blended color for start of trail.
		/// </summary>
		private void SetStartScale (float startScale)
		{
			Runtime.ValidateRefCounted (this);
			RibbonTrail_SetStartScale (handle, startScale);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void RibbonTrail_SetEndScale (IntPtr handle, float endScale);

		/// <summary>
		/// Set vertex blended scale for end of trail.
		/// </summary>
		private void SetEndScale (float endScale)
		{
			Runtime.ValidateRefCounted (this);
			RibbonTrail_SetEndScale (handle, endScale);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void RibbonTrail_SetTrailType (IntPtr handle, TrailType type);

		/// <summary>
		/// Set how the trail behave.
		/// </summary>
		private void SetTrailType (TrailType type)
		{
			Runtime.ValidateRefCounted (this);
			RibbonTrail_SetTrailType (handle, type);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void RibbonTrail_SetSorted (IntPtr handle, bool enable);

		/// <summary>
		/// Set whether tails are sorted by distance. Default false.
		/// </summary>
		private void SetSorted (bool enable)
		{
			Runtime.ValidateRefCounted (this);
			RibbonTrail_SetSorted (handle, enable);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void RibbonTrail_SetLifetime (IntPtr handle, float time);

		/// <summary>
		/// Set tail time to live.
		/// </summary>
		private void SetLifetime (float time)
		{
			Runtime.ValidateRefCounted (this);
			RibbonTrail_SetLifetime (handle, time);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void RibbonTrail_SetEmitting (IntPtr handle, bool emitting);

		/// <summary>
		/// Set whether trail should be emitting.
		/// </summary>
		private void SetEmitting (bool emitting)
		{
			Runtime.ValidateRefCounted (this);
			RibbonTrail_SetEmitting (handle, emitting);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void RibbonTrail_SetUpdateInvisible (IntPtr handle, bool enable);

		/// <summary>
		/// Set whether to update when trail emiiter are not visible.
		/// </summary>
		private void SetUpdateInvisible (bool enable)
		{
			Runtime.ValidateRefCounted (this);
			RibbonTrail_SetUpdateInvisible (handle, enable);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void RibbonTrail_SetTailColumn (IntPtr handle, uint tailColumn);

		/// <summary>
		/// Set number of column for every tails. Can be useful for fixing distortion at high angle.
		/// </summary>
		private void SetTailColumn (uint tailColumn)
		{
			Runtime.ValidateRefCounted (this);
			RibbonTrail_SetTailColumn (handle, tailColumn);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void RibbonTrail_SetAnimationLodBias (IntPtr handle, float bias);

		/// <summary>
		/// Set animation LOD bias.
		/// </summary>
		private void SetAnimationLodBias (float bias)
		{
			Runtime.ValidateRefCounted (this);
			RibbonTrail_SetAnimationLodBias (handle, bias);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void RibbonTrail_Commit (IntPtr handle);

		/// <summary>
		/// Mark for bounding box and vertex buffer update. Call after modifying the trails.
		/// </summary>
		public void Commit ()
		{
			Runtime.ValidateRefCounted (this);
			RibbonTrail_Commit (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr RibbonTrail_GetMaterial (IntPtr handle);

		/// <summary>
		/// Return material.
		/// </summary>
		private Material GetMaterial ()
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<Material> (RibbonTrail_GetMaterial (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern ResourceRef RibbonTrail_GetMaterialAttr (IntPtr handle);

		/// <summary>
		/// Return material attribute.
		/// </summary>
		private ResourceRef GetMaterialAttr ()
		{
			Runtime.ValidateRefCounted (this);
			return RibbonTrail_GetMaterialAttr (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float RibbonTrail_GetVertexDistance (IntPtr handle);

		/// <summary>
		/// Get distance between points.
		/// </summary>
		private float GetVertexDistance ()
		{
			Runtime.ValidateRefCounted (this);
			return RibbonTrail_GetVertexDistance (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float RibbonTrail_GetWidth (IntPtr handle);

		/// <summary>
		/// Get width of the trail.
		/// </summary>
		private float GetWidth ()
		{
			Runtime.ValidateRefCounted (this);
			return RibbonTrail_GetWidth (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.Color RibbonTrail_GetStartColor (IntPtr handle);

		/// <summary>
		/// Get vertex blended color for start of trail.
		/// </summary>
		private Urho.Color GetStartColor ()
		{
			Runtime.ValidateRefCounted (this);
			return RibbonTrail_GetStartColor (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.Color RibbonTrail_GetEndColor (IntPtr handle);

		/// <summary>
		/// Get vertex blended color for end of trail.
		/// </summary>
		private Urho.Color GetEndColor ()
		{
			Runtime.ValidateRefCounted (this);
			return RibbonTrail_GetEndColor (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float RibbonTrail_GetStartScale (IntPtr handle);

		/// <summary>
		/// Get vertex blended scale for start of trail.
		/// </summary>
		private float GetStartScale ()
		{
			Runtime.ValidateRefCounted (this);
			return RibbonTrail_GetStartScale (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float RibbonTrail_GetEndScale (IntPtr handle);

		/// <summary>
		/// Get vertex blended scale for end of trail.
		/// </summary>
		private float GetEndScale ()
		{
			Runtime.ValidateRefCounted (this);
			return RibbonTrail_GetEndScale (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool RibbonTrail_IsSorted (IntPtr handle);

		/// <summary>
		/// Return whether tails are sorted.
		/// </summary>
		private bool IsSorted ()
		{
			Runtime.ValidateRefCounted (this);
			return RibbonTrail_IsSorted (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float RibbonTrail_GetLifetime (IntPtr handle);

		/// <summary>
		/// Return tail time to live.
		/// </summary>
		private float GetLifetime ()
		{
			Runtime.ValidateRefCounted (this);
			return RibbonTrail_GetLifetime (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float RibbonTrail_GetAnimationLodBias (IntPtr handle);

		/// <summary>
		/// Return animation LOD bias.
		/// </summary>
		private float GetAnimationLodBias ()
		{
			Runtime.ValidateRefCounted (this);
			return RibbonTrail_GetAnimationLodBias (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern TrailType RibbonTrail_GetTrailType (IntPtr handle);

		/// <summary>
		/// Return how the trail behave.
		/// </summary>
		private TrailType GetTrailType ()
		{
			Runtime.ValidateRefCounted (this);
			return RibbonTrail_GetTrailType (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint RibbonTrail_GetTailColumn (IntPtr handle);

		/// <summary>
		/// Get number of column for tails.
		/// </summary>
		private uint GetTailColumn ()
		{
			Runtime.ValidateRefCounted (this);
			return RibbonTrail_GetTailColumn (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool RibbonTrail_IsEmitting (IntPtr handle);

		/// <summary>
		/// Return whether is currently emitting.
		/// </summary>
		private bool IsEmitting ()
		{
			Runtime.ValidateRefCounted (this);
			return RibbonTrail_IsEmitting (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool RibbonTrail_GetUpdateInvisible (IntPtr handle);

		/// <summary>
		/// Return whether to update when trail emitter are not visible.
		/// </summary>
		private bool GetUpdateInvisible ()
		{
			Runtime.ValidateRefCounted (this);
			return RibbonTrail_GetUpdateInvisible (handle);
		}

		public override StringHash Type {
			get {
				return UrhoGetType ();
			}
		}

		public override string TypeName {
			get {
				return GetTypeName ();
			}
		}

		public new static StringHash TypeStatic {
			get {
				return GetTypeStatic ();
			}
		}

		public new static string TypeNameStatic {
			get {
				return GetTypeNameStatic ();
			}
		}

		/// <summary>
		/// Return whether a geometry update is necessary, and if it can happen in a worker thread.
		/// </summary>
		public override UpdateGeometryType UpdateGeometryType {
			get {
				return GetUpdateGeometryType ();
			}
		}

		/// <summary>
		/// Return material.
		/// Or
		/// Set material.
		/// </summary>
		public Material Material {
			get {
				return GetMaterial ();
			}
			set {
				SetMaterial (value);
			}
		}

		/// <summary>
		/// Return material attribute.
		/// </summary>
		public ResourceRef MaterialAttr {
			get {
				return GetMaterialAttr ();
			}
		}

		/// <summary>
		/// Get distance between points.
		/// Or
		/// Set distance between points.
		/// </summary>
		public float VertexDistance {
			get {
				return GetVertexDistance ();
			}
			set {
				SetVertexDistance (value);
			}
		}

		/// <summary>
		/// Get width of the trail.
		/// Or
		/// Set width of the tail. Only works for face camera trail type.
		/// </summary>
		public float Width {
			get {
				return GetWidth ();
			}
			set {
				SetWidth (value);
			}
		}

		/// <summary>
		/// Get vertex blended color for start of trail.
		/// Or
		/// Set vertex blended color for start of trail.
		/// </summary>
		public Urho.Color StartColor {
			get {
				return GetStartColor ();
			}
			set {
				SetStartColor (value);
			}
		}

		/// <summary>
		/// Get vertex blended color for end of trail.
		/// Or
		/// Set vertex blended scale for end of trail.
		/// </summary>
		public Urho.Color EndColor {
			get {
				return GetEndColor ();
			}
			set {
				SetEndColor (value);
			}
		}

		/// <summary>
		/// Get vertex blended scale for start of trail.
		/// Or
		/// Set vertex blended color for start of trail.
		/// </summary>
		public float StartScale {
			get {
				return GetStartScale ();
			}
			set {
				SetStartScale (value);
			}
		}

		/// <summary>
		/// Get vertex blended scale for end of trail.
		/// Or
		/// Set vertex blended scale for end of trail.
		/// </summary>
		public float EndScale {
			get {
				return GetEndScale ();
			}
			set {
				SetEndScale (value);
			}
		}

		/// <summary>
		/// Return how the trail behave.
		/// Or
		/// Set how the trail behave.
		/// </summary>
		public TrailType TrailType {
			get {
				return GetTrailType ();
			}
			set {
				SetTrailType (value);
			}
		}

		/// <summary>
		/// Return whether tails are sorted.
		/// Or
		/// Set whether tails are sorted by distance. Default false.
		/// </summary>
		public bool Sorted {
			get {
				return IsSorted ();
			}
			set {
				SetSorted (value);
			}
		}

		/// <summary>
		/// Return tail time to live.
		/// Or
		/// Set tail time to live.
		/// </summary>
		public float Lifetime {
			get {
				return GetLifetime ();
			}
			set {
				SetLifetime (value);
			}
		}

		/// <summary>
		/// Return whether is currently emitting.
		/// Or
		/// Set whether trail should be emitting.
		/// </summary>
		public bool Emitting {
			get {
				return IsEmitting ();
			}
			set {
				SetEmitting (value);
			}
		}

		/// <summary>
		/// Return whether to update when trail emitter are not visible.
		/// Or
		/// Set whether to update when trail emiiter are not visible.
		/// </summary>
		public bool UpdateInvisible {
			get {
				return GetUpdateInvisible ();
			}
			set {
				SetUpdateInvisible (value);
			}
		}

		/// <summary>
		/// Get number of column for tails.
		/// Or
		/// Set number of column for every tails. Can be useful for fixing distortion at high angle.
		/// </summary>
		public uint TailColumn {
			get {
				return GetTailColumn ();
			}
			set {
				SetTailColumn (value);
			}
		}

		/// <summary>
		/// Return animation LOD bias.
		/// Or
		/// Set animation LOD bias.
		/// </summary>
		public float AnimationLodBias {
			get {
				return GetAnimationLodBias ();
			}
			set {
				SetAnimationLodBias (value);
			}
		}
	}
}