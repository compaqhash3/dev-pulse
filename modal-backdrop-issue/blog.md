😅 Ever opened your ASP.NET modal multiple times and noticed the backdrop stacking darker and darker?

That happened to me when reopening a Bootstrap modal after postbacks. At first glance, it looks like a Bootstrap bug — but actually, it’s how we trigger the modal.

Here’s what caused it:
 ❌ Calling .modal('show') without cleaning up old backdrops.
 ❌ UpdatePanel re-renders leaving multiple modal layers behind.

✅ The Fix:

✔️ Make sure the modal HTML is outside the UpdatePanel.
✔️ Always clean up or reuse the same modal instance.
✔️ If you re-open modals after async postbacks, reattach them safely:

$('hashtag#myModal').on('hidden.bs.modal', function () {
 $(this).removeAttr('data-keep-open');
 $('.modal-backdrop').remove(); // cleanup
});

Now my modal opens and closes cleanly every time 🙌 — no more “infinite dark mode.”
